from typing import Literal, Optional

import aind_behavior_services.rig as rig
from aind_behavior_services.calibration import aind_manipulator
from pydantic import Field

from . import __semver__


class SerialScale(rig.Device):
    device_type: Literal["SerialScale"] = "SerialScale"
    port_name: str = Field(..., description="COM port to which the scale is connected")


class AindBehaviorDeviceWaterTunerRig(rig.AindBehaviorRigModel):
    version: Literal[__semver__] = __semver__
    scale: SerialScale = Field(..., title="Serial scale device")
    harp_behavior: rig.harp.HarpBehavior = Field(..., description="Harp behavior")
    manipulator: Optional[aind_manipulator.AindManipulatorDevice] = Field(default=None, description="Manipulator")
