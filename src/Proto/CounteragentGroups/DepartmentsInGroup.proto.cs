//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CounteragentGroups/DepartmentsInGroup.proto
namespace Diadoc.Api.Proto.CounteragentGroups
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DepartmentsInGroup")]
  public partial class DepartmentsInGroup : global::ProtoBuf.IExtensible
  {
    public DepartmentsInGroup() {}
    
    private readonly global::System.Collections.Generic.List<string> _DepartmentId = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"DepartmentId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> DepartmentId
    {
      get { return _DepartmentId; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}