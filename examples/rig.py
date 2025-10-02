import os

import aind_behavior_services.rig
from aind_behavior_services.calibration import aind_manipulator
from aind_behavior_services.calibration.aind_manipulator import (
    AindManipulatorCalibration,
    AindManipulatorCalibrationInput,
    AindManipulatorCalibrationOutput,
    Axis,
    AxisConfiguration,
    ManipulatorPosition,
)

from aind_behavior_device_water_tuner.rig import AindBehaviorDeviceWaterTunerRig, SerialScale

manipulator_calibration = AindManipulatorCalibration(
    output=AindManipulatorCalibrationOutput(),
    input=AindManipulatorCalibrationInput(
        full_step_to_mm=(ManipulatorPosition(x=0.010, y1=0.010, y2=0.010, z=0.010)),
        axis_configuration=[
            AxisConfiguration(axis=Axis.Y1, min_limit=-1, max_limit=15000),
            AxisConfiguration(axis=Axis.Y2, min_limit=-1, max_limit=15000),
            AxisConfiguration(axis=Axis.X, min_limit=-1, max_limit=15000),
            AxisConfiguration(axis=Axis.Z, min_limit=-1, max_limit=15000),
        ],
        homing_order=[Axis.Y1, Axis.Y2, Axis.X, Axis.Z],
        initial_position=ManipulatorPosition(y1=0, y2=0, x=0, z=0),
    ),
)

rig = AindBehaviorDeviceWaterTunerRig(
    rig_name="testrig",
    harp_behavior=aind_behavior_services.rig.harp.HarpBehavior(port_name="COM3"),
    manipulator=aind_manipulator.AindManipulatorDevice(port_name="COM10", calibration=manipulator_calibration),
    scale=SerialScale(port_name="COM12"),
)


def main(path_seed: str = "./local/{schema}.json"):
    os.makedirs(os.path.dirname(path_seed), exist_ok=True)
    models = [rig]

    for model in models:
        with open(path_seed.format(schema=model.__class__.__name__), "w", encoding="utf-8") as f:
            f.write(model.model_dump_json(indent=2))


if __name__ == "__main__":
    main()
