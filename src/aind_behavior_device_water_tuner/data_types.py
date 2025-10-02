from aind_behavior_services.calibration import water_valve as wv
from pydantic import BaseModel


class ExtensionDataTypes(BaseModel):
    calibration: wv.WaterValveCalibration
