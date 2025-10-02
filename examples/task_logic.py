import os

from aind_behavior_curriculum import Stage, TrainerState

from aind_behavior_device_water_tuner.task_logic import (
    AindBehaviorDeviceWaterTunerTaskLogic,
    AindBehaviorDeviceWaterTunerTaskParameters,
)

task_logic = AindBehaviorDeviceWaterTunerTaskLogic(
    task_parameters=AindBehaviorDeviceWaterTunerTaskParameters(
        repeat_count=200, valve_open_interval=0.2, valve_open_time=[0.02, 0.05, 0.1]
    )
)


def main(path_seed: str = "./local/example_{schema}.json"):
    example_task_logic = task_logic
    example_trainer_state = TrainerState(
        stage=Stage(name="example_stage", task=example_task_logic), curriculum=None, is_on_curriculum=False
    )
    os.makedirs(os.path.dirname(path_seed), exist_ok=True)
    models = [example_task_logic, example_trainer_state]

    for model in models:
        with open(path_seed.format(schema=model.__class__.__name__), "w", encoding="utf-8") as f:
            f.write(model.model_dump_json(indent=2))


if __name__ == "__main__":
    main()
