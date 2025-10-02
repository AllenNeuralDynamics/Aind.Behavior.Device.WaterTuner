from pathlib import Path

from aind_behavior_services.session import AindBehaviorSessionModel
from clabe import resource_monitor
from clabe.apps import (
    AindBehaviorServicesBonsaiApp,
    BonsaiAppSettings,
)
from clabe.launcher import (
    DefaultBehaviorPicker,
    DefaultBehaviorPickerSettings,
    Launcher,
    LauncherCliArgs,
)
from pydantic_settings import CliApp

from .rig import AindBehaviorDeviceWaterTunerRig
from .task_logic import AindBehaviorDeviceWaterTunerTaskLogic


def make_launcher(settings: LauncherCliArgs) -> Launcher:
    monitor = resource_monitor.ResourceMonitor(
        constrains=[
            resource_monitor.available_storage_constraint_factory(settings.data_dir, 2e11),
        ]
    )
    bonsai_app = AindBehaviorServicesBonsaiApp(BonsaiAppSettings(workflow=Path(r"./src/main.bonsai")))
    picker = DefaultBehaviorPicker[
        AindBehaviorDeviceWaterTunerRig, AindBehaviorSessionModel, AindBehaviorDeviceWaterTunerTaskLogic
    ](
        settings=DefaultBehaviorPickerSettings()  # type: ignore[call-arg]
    )
    launcher = Launcher(
        rig=AindBehaviorDeviceWaterTunerRig,
        session=AindBehaviorSessionModel,
        task_logic=AindBehaviorDeviceWaterTunerTaskLogic,
        settings=settings,
    )

    # Get user input
    launcher.register_callable(
        [
            picker.initialize,
            picker.pick_session,
            picker.pick_trainer_state,
            picker.pick_rig,
        ]
    )

    # Check resources
    launcher.register_callable(monitor.build_runner())

    # Run the task via Bonsai
    launcher.register_callable(bonsai_app.build_runner(allow_std_error=True))

    return launcher


class ClabeCli(LauncherCliArgs):
    def cli_cmd(self):
        launcher = make_launcher(self)
        launcher.main()
        return None


def main() -> None:
    CliApp().run(ClabeCli)


if __name__ == "__main__":
    main()
