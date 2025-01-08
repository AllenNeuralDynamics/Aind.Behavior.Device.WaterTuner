//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------


namespace AindBehaviorWaterTuner.TaskLogic
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class AindBehaviorWaterTunerParameters
    {
    
        private double? _rngSeed;
    
        private string _aindBehaviorServicesPkgVersion = "0.8.9";
    
        private System.Collections.Generic.List<double> _valveOpenTime = new System.Collections.Generic.List<double>();
    
        private double _valveOpenInterval = 0.2D;
    
        private int _repeatCount = 200;
    
        public AindBehaviorWaterTunerParameters()
        {
        }
    
        protected AindBehaviorWaterTunerParameters(AindBehaviorWaterTunerParameters other)
        {
            _rngSeed = other._rngSeed;
            _aindBehaviorServicesPkgVersion = other._aindBehaviorServicesPkgVersion;
            _valveOpenTime = other._valveOpenTime;
            _valveOpenInterval = other._valveOpenInterval;
            _repeatCount = other._repeatCount;
        }
    
        /// <summary>
        /// Seed of the random number generator
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("rng_seed")]
        [System.ComponentModel.DescriptionAttribute("Seed of the random number generator")]
        public double? RngSeed
        {
            get
            {
                return _rngSeed;
            }
            set
            {
                _rngSeed = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("aind_behavior_services_pkg_version")]
        public string AindBehaviorServicesPkgVersion
        {
            get
            {
                return _aindBehaviorServicesPkgVersion;
            }
            set
            {
                _aindBehaviorServicesPkgVersion = value;
            }
        }
    
        /// <summary>
        /// An array with the times (s) the valve is open during calibration
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("valve_open_time", Required=Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DescriptionAttribute("An array with the times (s) the valve is open during calibration")]
        public System.Collections.Generic.List<double> ValveOpenTime
        {
            get
            {
                return _valveOpenTime;
            }
            set
            {
                _valveOpenTime = value;
            }
        }
    
        /// <summary>
        /// Time between two consecutive valve openings (s)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valve_open_interval")]
        [System.ComponentModel.DescriptionAttribute("Time between two consecutive valve openings (s)")]
        public double ValveOpenInterval
        {
            get
            {
                return _valveOpenInterval;
            }
            set
            {
                _valveOpenInterval = value;
            }
        }
    
        /// <summary>
        /// Number of times the valve opened per measure valve_open_time entry
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeat_count")]
        [System.ComponentModel.DescriptionAttribute("Number of times the valve opened per measure valve_open_time entry")]
        public int RepeatCount
        {
            get
            {
                return _repeatCount;
            }
            set
            {
                _repeatCount = value;
            }
        }
    
        public System.IObservable<AindBehaviorWaterTunerParameters> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new AindBehaviorWaterTunerParameters(this)));
        }
    
        public System.IObservable<AindBehaviorWaterTunerParameters> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new AindBehaviorWaterTunerParameters(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("rng_seed = " + _rngSeed + ", ");
            stringBuilder.Append("aind_behavior_services_pkg_version = " + _aindBehaviorServicesPkgVersion + ", ");
            stringBuilder.Append("valve_open_time = " + _valveOpenTime + ", ");
            stringBuilder.Append("valve_open_interval = " + _valveOpenInterval + ", ");
            stringBuilder.Append("repeat_count = " + _repeatCount);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    /// <summary>
    /// WaterTuner operation control model that is used to run a calibration data acquisition workflow
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("WaterTuner operation control model that is used to run a calibration data acquisi" +
        "tion workflow")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Source)]
    public partial class AindBehaviorWaterTunerTaskLogic
    {
    
        private string _name = "WaterValveCalibrationLogic";
    
        private string _description = "";
    
        private AindBehaviorWaterTunerParameters _taskParameters = new AindBehaviorWaterTunerParameters();
    
        private string _version = "0.1.0";
    
        private string _stageName;
    
        public AindBehaviorWaterTunerTaskLogic()
        {
        }
    
        protected AindBehaviorWaterTunerTaskLogic(AindBehaviorWaterTunerTaskLogic other)
        {
            _name = other._name;
            _description = other._description;
            _taskParameters = other._taskParameters;
            _version = other._version;
            _stageName = other._stageName;
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    
        /// <summary>
        /// Description of the task.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        [System.ComponentModel.DescriptionAttribute("Description of the task.")]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [Newtonsoft.Json.JsonPropertyAttribute("task_parameters", Required=Newtonsoft.Json.Required.Always)]
        public AindBehaviorWaterTunerParameters TaskParameters
        {
            get
            {
                return _taskParameters;
            }
            set
            {
                _taskParameters = value;
            }
        }
    
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }
    
        /// <summary>
        /// Optional stage name the `Task` object instance represents.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stage_name")]
        [System.ComponentModel.DescriptionAttribute("Optional stage name the `Task` object instance represents.")]
        public string StageName
        {
            get
            {
                return _stageName;
            }
            set
            {
                _stageName = value;
            }
        }
    
        public System.IObservable<AindBehaviorWaterTunerTaskLogic> Process()
        {
            return System.Reactive.Linq.Observable.Defer(() => System.Reactive.Linq.Observable.Return(new AindBehaviorWaterTunerTaskLogic(this)));
        }
    
        public System.IObservable<AindBehaviorWaterTunerTaskLogic> Process<TSource>(System.IObservable<TSource> source)
        {
            return System.Reactive.Linq.Observable.Select(source, _ => new AindBehaviorWaterTunerTaskLogic(this));
        }
    
        protected virtual bool PrintMembers(System.Text.StringBuilder stringBuilder)
        {
            stringBuilder.Append("name = " + _name + ", ");
            stringBuilder.Append("description = " + _description + ", ");
            stringBuilder.Append("task_parameters = " + _taskParameters + ", ");
            stringBuilder.Append("version = " + _version + ", ");
            stringBuilder.Append("stage_name = " + _stageName);
            return true;
        }
    
        public override string ToString()
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            stringBuilder.Append(GetType().Name);
            stringBuilder.Append(" { ");
            if (PrintMembers(stringBuilder))
            {
                stringBuilder.Append(" ");
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }


    /// <summary>
    /// Serializes a sequence of data model objects into JSON strings.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Serializes a sequence of data model objects into JSON strings.")]
    [Bonsai.CombinatorAttribute()]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    public partial class SerializeToJson
    {
    
        private System.IObservable<string> Process<T>(System.IObservable<T> source)
        {
            return System.Reactive.Linq.Observable.Select(source, value => Newtonsoft.Json.JsonConvert.SerializeObject(value));
        }

        public System.IObservable<string> Process(System.IObservable<AindBehaviorWaterTunerParameters> source)
        {
            return Process<AindBehaviorWaterTunerParameters>(source);
        }

        public System.IObservable<string> Process(System.IObservable<AindBehaviorWaterTunerTaskLogic> source)
        {
            return Process<AindBehaviorWaterTunerTaskLogic>(source);
        }
    }


    /// <summary>
    /// Deserializes a sequence of JSON strings into data model objects.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Bonsai.Sgen", "0.4.0.0 (Newtonsoft.Json v13.0.0.0)")]
    [System.ComponentModel.DescriptionAttribute("Deserializes a sequence of JSON strings into data model objects.")]
    [System.ComponentModel.DefaultPropertyAttribute("Type")]
    [Bonsai.WorkflowElementCategoryAttribute(Bonsai.ElementCategory.Transform)]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<AindBehaviorWaterTunerParameters>))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Bonsai.Expressions.TypeMapping<AindBehaviorWaterTunerTaskLogic>))]
    public partial class DeserializeFromJson : Bonsai.Expressions.SingleArgumentExpressionBuilder
    {
    
        public DeserializeFromJson()
        {
            Type = new Bonsai.Expressions.TypeMapping<AindBehaviorWaterTunerTaskLogic>();
        }

        public Bonsai.Expressions.TypeMapping Type { get; set; }

        public override System.Linq.Expressions.Expression Build(System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression> arguments)
        {
            var typeMapping = (Bonsai.Expressions.TypeMapping)Type;
            var returnType = typeMapping.GetType().GetGenericArguments()[0];
            return System.Linq.Expressions.Expression.Call(
                typeof(DeserializeFromJson),
                "Process",
                new System.Type[] { returnType },
                System.Linq.Enumerable.Single(arguments));
        }

        private static System.IObservable<T> Process<T>(System.IObservable<string> source)
        {
            return System.Reactive.Linq.Observable.Select(source, value => Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value));
        }
    }
}