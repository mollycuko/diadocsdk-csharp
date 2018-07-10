//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Docflow/DocflowV3.proto
// Note: requires additional types generated from: Timestamp.proto
// Note: requires additional types generated from: Documents/Document.proto
// Note: requires additional types generated from: Docflow/AttachmentV3.proto
// Note: requires additional types generated from: Docflow/RoamingNotification.proto
namespace Diadoc.Api.Proto.Docflow
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocflowV3")]
  public partial class DocflowV3 : global::ProtoBuf.IExtensible
  {
    public DocflowV3() {}
    
    private Diadoc.Api.Proto.Docflow.SenderTitleDocflow _SenderTitle;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"SenderTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.SenderTitleDocflow SenderTitle
    {
      get { return _SenderTitle; }
      set { _SenderTitle = value; }
    }

    private Diadoc.Api.Proto.Docflow.ConfirmationDocflow _Confirmation = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Confirmation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ConfirmationDocflow Confirmation
    {
      get { return _Confirmation; }
      set { _Confirmation = value; }
    }

    private Diadoc.Api.Proto.Docflow.ProxyResponseDocflow _ProxyResponse = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ProxyResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ProxyResponseDocflow ProxyResponse
    {
      get { return _ProxyResponse; }
      set { _ProxyResponse = value; }
    }

    private Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 _RecipientReceipt = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RecipientReceipt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 RecipientReceipt
    {
      get { return _RecipientReceipt; }
      set { _RecipientReceipt = value; }
    }

    private Diadoc.Api.Proto.Docflow.RecipientResponseDocflow _RecipientResponse = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RecipientResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RecipientResponseDocflow RecipientResponse
    {
      get { return _RecipientResponse; }
      set { _RecipientResponse = value; }
    }

    private Diadoc.Api.Proto.Docflow.AmendmentRequestDocflow _AmendmentRequest = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AmendmentRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.AmendmentRequestDocflow AmendmentRequest
    {
      get { return _AmendmentRequest; }
      set { _AmendmentRequest = value; }
    }

    private Diadoc.Api.Proto.Docflow.RevocationDocflowV3 _Revocation = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Revocation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RevocationDocflowV3 Revocation
    {
      get { return _Revocation; }
      set { _Revocation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SenderTitleDocflow")]
  public partial class SenderTitleDocflow : global::ProtoBuf.IExtensible
  {
    public SenderTitleDocflow() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }
    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _Attachment;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Attachment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 Attachment
    {
      get { return _Attachment; }
      set { _Attachment = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SentAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SentAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SentAt
    {
      get { return _SentAt; }
      set { _SentAt = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }

    private Diadoc.Api.Proto.Docflow.RoamingNotification _RoamingNotification = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RoamingNotification", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RoamingNotification RoamingNotification
    {
      get { return _RoamingNotification; }
      set { _RoamingNotification = value; }
    }
    private Diadoc.Api.Proto.Documents.SenderSignatureStatus _SenderSignatureStatus;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"SenderSignatureStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Documents.SenderSignatureStatus SenderSignatureStatus
    {
      get { return _SenderSignatureStatus; }
      set { _SenderSignatureStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ConfirmationDocflow")]
  public partial class ConfirmationDocflow : global::ProtoBuf.IExtensible
  {
    public ConfirmationDocflow() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _ConfirmationAttachment = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ConfirmationAttachment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 ConfirmationAttachment
    {
      get { return _ConfirmationAttachment; }
      set { _ConfirmationAttachment = value; }
    }

    private Diadoc.Api.Proto.Timestamp _ConfirmedAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ConfirmedAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp ConfirmedAt
    {
      get { return _ConfirmedAt; }
      set { _ConfirmedAt = value; }
    }

    private Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 _Receipt = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Receipt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 Receipt
    {
      get { return _Receipt; }
      set { _Receipt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProxyResponseDocflow")]
  public partial class ProxyResponseDocflow : global::ProtoBuf.IExtensible
  {
    public ProxyResponseDocflow() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignatureV3 _Signature = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureV3 Signature
    {
      get { return _Signature; }
      set { _Signature = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow _Rejection = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Rejection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow Rejection
    {
      get { return _Rejection; }
      set { _Rejection = value; }
    }
    private Diadoc.Api.Proto.Documents.ProxySignatureStatus _ProxySignatureStatus;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"ProxySignatureStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Documents.ProxySignatureStatus ProxySignatureStatus
    {
      get { return _ProxySignatureStatus; }
      set { _ProxySignatureStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SignatureRejectionDocflow")]
  public partial class SignatureRejectionDocflow : global::ProtoBuf.IExtensible
  {
    public SignatureRejectionDocflow() {}
    
    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _SignatureRejection;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"SignatureRejection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 SignatureRejection
    {
      get { return _SignatureRejection; }
      set { _SignatureRejection = value; }
    }
    private bool _IsFormal;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"IsFormal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFormal
    {
      get { return _IsFormal; }
      set { _IsFormal = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RecipientResponseDocflow")]
  public partial class RecipientResponseDocflow : global::ProtoBuf.IExtensible
  {
    public RecipientResponseDocflow() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignatureV3 _Signature = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureV3 Signature
    {
      get { return _Signature; }
      set { _Signature = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _RecipientTitle = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RecipientTitle", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 RecipientTitle
    {
      get { return _RecipientTitle; }
      set { _RecipientTitle = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow _Rejection = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Rejection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow Rejection
    {
      get { return _Rejection; }
      set { _Rejection = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SentAt = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"SentAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SentAt
    {
      get { return _SentAt; }
      set { _SentAt = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }
    private Diadoc.Api.Proto.Documents.RecipientResponseStatus _RecipientResponseStatus;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"RecipientResponseStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Documents.RecipientResponseStatus RecipientResponseStatus
    {
      get { return _RecipientResponseStatus; }
      set { _RecipientResponseStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AmendmentRequestDocflow")]
  public partial class AmendmentRequestDocflow : global::ProtoBuf.IExtensible
  {
    public AmendmentRequestDocflow() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }
    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _AmendmentRequest;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"AmendmentRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 AmendmentRequest
    {
      get { return _AmendmentRequest; }
      set { _AmendmentRequest = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SentAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SentAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SentAt
    {
      get { return _SentAt; }
      set { _SentAt = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }

    private Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 _Receipt = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Receipt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ReceiptDocflowV3 Receipt
    {
      get { return _Receipt; }
      set { _Receipt = value; }
    }
    private int _AmendmentFlags;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"AmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AmendmentFlags
    {
      get { return _AmendmentFlags; }
      set { _AmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RevocationDocflowV3")]
  public partial class RevocationDocflowV3 : global::ProtoBuf.IExtensible
  {
    public RevocationDocflowV3() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }
    private Diadoc.Api.Proto.Docflow.RevocationRequestDocflow _RevocationRequest;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"RevocationRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.RevocationRequestDocflow RevocationRequest
    {
      get { return _RevocationRequest; }
      set { _RevocationRequest = value; }
    }

    private Diadoc.Api.Proto.Docflow.RevocationResponseDocflow _RevocationResponse = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RevocationResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RevocationResponseDocflow RevocationResponse
    {
      get { return _RevocationResponse; }
      set { _RevocationResponse = value; }
    }
    private string _InitiatorBoxId;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"InitiatorBoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string InitiatorBoxId
    {
      get { return _InitiatorBoxId; }
      set { _InitiatorBoxId = value; }
    }
    private Diadoc.Api.Proto.Documents.RevocationStatus _RevocationStatus;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"RevocationStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Documents.RevocationStatus RevocationStatus
    {
      get { return _RevocationStatus; }
      set { _RevocationStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RevocationRequestDocflow")]
  public partial class RevocationRequestDocflow : global::ProtoBuf.IExtensible
  {
    public RevocationRequestDocflow() {}
    
    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _RevocationRequest;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RevocationRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 RevocationRequest
    {
      get { return _RevocationRequest; }
      set { _RevocationRequest = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SentAt = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SentAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SentAt
    {
      get { return _SentAt; }
      set { _SentAt = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }

    private Diadoc.Api.Proto.Docflow.RoamingNotification _RoamingNotification = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RoamingNotification", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.RoamingNotification RoamingNotification
    {
      get { return _RoamingNotification; }
      set { _RoamingNotification = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RevocationResponseDocflow")]
  public partial class RevocationResponseDocflow : global::ProtoBuf.IExtensible
  {
    public RevocationResponseDocflow() {}
    

    private Diadoc.Api.Proto.Docflow.SignatureV3 _RecipientSignature = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RecipientSignature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureV3 RecipientSignature
    {
      get { return _RecipientSignature; }
      set { _RecipientSignature = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow _SignatureRejection = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SignatureRejection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignatureRejectionDocflow SignatureRejection
    {
      get { return _SignatureRejection; }
      set { _SignatureRejection = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReceiptDocflowV3")]
  public partial class ReceiptDocflowV3 : global::ProtoBuf.IExtensible
  {
    public ReceiptDocflowV3() {}
    
    private bool _IsFinished;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"IsFinished", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool IsFinished
    {
      get { return _IsFinished; }
      set { _IsFinished = value; }
    }

    private Diadoc.Api.Proto.Docflow.SignedAttachmentV3 _ReceiptAttachment = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ReceiptAttachment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.SignedAttachmentV3 ReceiptAttachment
    {
      get { return _ReceiptAttachment; }
      set { _ReceiptAttachment = value; }
    }

    private Diadoc.Api.Proto.Timestamp _SentAt = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SentAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp SentAt
    {
      get { return _SentAt; }
      set { _SentAt = value; }
    }

    private Diadoc.Api.Proto.Timestamp _DeliveredAt = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DeliveredAt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Timestamp DeliveredAt
    {
      get { return _DeliveredAt; }
      set { _DeliveredAt = value; }
    }

    private Diadoc.Api.Proto.Docflow.ConfirmationDocflow _Confirmation = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Confirmation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Docflow.ConfirmationDocflow Confirmation
    {
      get { return _Confirmation; }
      set { _Confirmation = value; }
    }
    private Diadoc.Api.Proto.Documents.GeneralReceiptStatus _Status;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Documents.GeneralReceiptStatus Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}