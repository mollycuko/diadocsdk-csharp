//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Events/PowerOfAttorneyInfo.proto
// Note: requires additional types generated from: PowersOfAttorney/PowerOfAttorney.proto
// Note: requires additional types generated from: PowersOfAttorney/PowerOfAttorneyValidation.proto
namespace Diadoc.Api.Proto.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PowerOfAttorneyInfo")]
  public partial class PowerOfAttorneyInfo : global::ProtoBuf.IExtensible
  {
    public PowerOfAttorneyInfo() {}
    
    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId _FullId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FullId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyFullId FullId
    {
      get { return _FullId; }
      set { _FullId = value; }
    }

    private Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyValidationStatus _Status = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.PowersOfAttorney.PowerOfAttorneyValidationStatus Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}