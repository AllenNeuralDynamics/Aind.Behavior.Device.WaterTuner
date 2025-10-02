import typing as t

from pydantic import Field, RootModel
from pydantic_settings import BaseSettings, CliApp, CliSubCommand

from aind_behavior_device_water_tuner import __semver__, regenerate
from aind_behavior_device_water_tuner.launcher import ClabeCli


class VersionCli(RootModel):
    root: t.Any

    def cli_cmd(self) -> None:
        print(__semver__)


class DslRegenerateCli(RootModel):
    root: t.Any

    def cli_cmd(self) -> None:
        regenerate.main()


class WaterTuner(BaseSettings, cli_prog_name="water-tuner", cli_kebab_case=True):
    version: CliSubCommand[VersionCli] = Field(
        description="Print the version of the water-tuner package.",
    )
    regenerate: CliSubCommand[DslRegenerateCli] = Field(
        description="Regenerate the water-tuner dsl dependencies.",
    )
    clabe: CliSubCommand[ClabeCli] = Field(
        description="Run the Clabe CLI.",
    )

    def cli_cmd(self):
        return CliApp().run_subcommand(self)


def main():
    CliApp().run(WaterTuner)


if __name__ == "__main__":
    main()
