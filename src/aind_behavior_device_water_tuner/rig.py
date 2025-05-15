from typing import Literal, Optional

import aind_behavior_services.rig as rig
from aind_behavior_services.calibration import aind_manipulator
from aind_behavior_services.rig import AindBehaviorRigModel
from pydantic import Field

__version__ = "0.2.0"


class SerialScale(rig.Device):
    device_type: Literal["SerialScale"] = "SerialScale"
    port_name: str = Field(..., description="COM port to which the scale is connected")


class AindBehaviorWaterTunerRig(AindBehaviorRigModel):
    version: Literal[__version__] = __version__
    scale: SerialScale = Field(..., title="Serial scale device")
    harp_behavior: rig.harp.HarpBehavior = Field(..., description="Harp behavior")
    manipulator: Optional[aind_manipulator.AindManipulatorDevice] = Field(default=None, description="Manipulator")
