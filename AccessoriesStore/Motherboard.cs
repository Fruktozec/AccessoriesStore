//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccessoriesStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Motherboard
    {
        public int ID { get; set; }
        public int ProductMBID { get; set; }
        public string ProcessorSupport { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public string FormFactor { get; set; }
        public string MemoryType { get; set; }
        public string NumberMemorySlots { get; set; }
        public string MaximumMemorySize { get; set; }
        public string MemoryMode { get; set; }
        public string MaximumMemoryFrequency { get; set; }
        public string StorageInterfaces { get; set; }
        public string NetworkAndCommunication { get; set; }
        public string AudioAndVideo { get; set; }
        public string RearPanelConnectors { get; set; }
        public string InternalConnectors { get; set; }
        public string OverallDimensions { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
