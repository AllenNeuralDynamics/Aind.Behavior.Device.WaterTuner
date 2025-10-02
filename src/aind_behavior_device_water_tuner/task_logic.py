import logging
from typing import Literal

from aind_behavior_services.task_logic import AindBehaviorTaskLogicModel, TaskParameters
from pydantic import Field, PositiveFloat

from aind_behavior_device_water_tuner import (
    __semver__,
)

logger = logging.getLogger(__name__)

# ==================== MAIN TASK LOGIC CLASSES ====================


class AindBehaviorDeviceWaterTunerTaskParameters(TaskParameters):
    valve_open_time: list[PositiveFloat] = Field(
        ...,
        min_length=1,
        description="An array with the times (s) the valve is open during calibration",
    )
    valve_open_interval: float = Field(
        default=0.2,
        description="Time between two consecutive valve openings (s)",
        title="Valve open interval",
        gt=0,
    )
    repeat_count: int = Field(
        default=200,
        ge=1,
        description="Number of times the valve opened per measure valve_open_time entry",
        title="Repeat count",
    )


class AindBehaviorDeviceWaterTunerTaskLogic(AindBehaviorTaskLogicModel):
    """
    Main task logic model for the water-tuner task.
    """

    version: Literal[__semver__] = __semver__
    name: Literal["AindBehaviorDeviceWaterTuner"] = Field(
        default="AindBehaviorDeviceWaterTuner", description="Name of the task logic", frozen=True
    )
    task_parameters: AindBehaviorDeviceWaterTunerTaskParameters = Field(description="Parameters of the task logic")
