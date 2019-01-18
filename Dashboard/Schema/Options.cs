// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: options.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SquaredUp.Dashboard.Schema {

  /// <summary>Holder for reflection information generated from options.proto</summary>
  public static partial class OptionsReflection {

    #region Descriptor
    /// <summary>File descriptor for options.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OptionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1vcHRpb25zLnByb3RvEglzcXVhcmVkdXAaIGdvb2dsZS9wcm90b2J1Zi9k",
            "ZXNjcmlwdG9yLnByb3RvIv0BChVTcXVhcmVkVXBGaWVsZE9wdGlvbnMSDwoH",
            "aXNfZ3VpZBgBIAEoCBIdChVmb3JfcGVyc3BlY3RpdmVzX29ubHkYAiABKAgS",
            "GwoTZm9yX2Rhc2hib2FyZHNfb25seRgDIAEoCBIVCg1pc191c2VyX3ZhbHVl",
            "GAQgASgIEgsKA2RvYxgFIAEoCRIZChFub3JtYWxseV9yZXF1aXJlZBgGIAEo",
            "CBIeChZyZXF1aXJlc19jb25maWd1cmF0aW9uGAcgASgIEhoKEmNpcmN1bXN0",
            "YW50aWFsX3VzZRgIIAEoCBIcChRpc19jb25zdHJhaW5lZF92YWx1ZRgJIAEo",
            "CDpMCgFvEh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxjShgMgASgL",
            "MiAuc3F1YXJlZHVwLlNxdWFyZWRVcEZpZWxkT3B0aW9uc0IdqgIaU3F1YXJl",
            "ZFVwLkRhc2hib2FyZC5TY2hlbWFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { pbr::FileDescriptor.DescriptorProtoFileDescriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SquaredUp.Dashboard.Schema.SquaredUpFieldOptions), global::SquaredUp.Dashboard.Schema.SquaredUpFieldOptions.Parser, new[]{ "IsGuid", "ForPerspectivesOnly", "ForDashboardsOnly", "IsUserValue", "Doc", "NormallyRequired", "RequiresConfiguration", "CircumstantialUse", "IsConstrainedValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SquaredUpFieldOptions : pb::IMessage<SquaredUpFieldOptions> {
    private static readonly pb::MessageParser<SquaredUpFieldOptions> _parser = new pb::MessageParser<SquaredUpFieldOptions>(() => new SquaredUpFieldOptions());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SquaredUpFieldOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SquaredUp.Dashboard.Schema.OptionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquaredUpFieldOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquaredUpFieldOptions(SquaredUpFieldOptions other) : this() {
      isGuid_ = other.isGuid_;
      forPerspectivesOnly_ = other.forPerspectivesOnly_;
      forDashboardsOnly_ = other.forDashboardsOnly_;
      isUserValue_ = other.isUserValue_;
      doc_ = other.doc_;
      normallyRequired_ = other.normallyRequired_;
      requiresConfiguration_ = other.requiresConfiguration_;
      circumstantialUse_ = other.circumstantialUse_;
      isConstrainedValue_ = other.isConstrainedValue_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SquaredUpFieldOptions Clone() {
      return new SquaredUpFieldOptions(this);
    }

    /// <summary>Field number for the "is_guid" field.</summary>
    public const int IsGuidFieldNumber = 1;
    private bool isGuid_;
    /// <summary>
    /// Is the field a GUID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsGuid {
      get { return isGuid_; }
      set {
        isGuid_ = value;
      }
    }

    /// <summary>Field number for the "for_perspectives_only" field.</summary>
    public const int ForPerspectivesOnlyFieldNumber = 2;
    private bool forPerspectivesOnly_;
    /// <summary>
    /// Field is only relevant to perspectives
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForPerspectivesOnly {
      get { return forPerspectivesOnly_; }
      set {
        forPerspectivesOnly_ = value;
      }
    }

    /// <summary>Field number for the "for_dashboards_only" field.</summary>
    public const int ForDashboardsOnlyFieldNumber = 3;
    private bool forDashboardsOnly_;
    /// <summary>
    /// Field is only relevant for (non perspective) dashboards
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ForDashboardsOnly {
      get { return forDashboardsOnly_; }
      set {
        forDashboardsOnly_ = value;
      }
    }

    /// <summary>Field number for the "is_user_value" field.</summary>
    public const int IsUserValueFieldNumber = 4;
    private bool isUserValue_;
    /// <summary>
    /// The value of the field can be any user-defined input and has no functional meaning 
    /// to Squared Up
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsUserValue {
      get { return isUserValue_; }
      set {
        isUserValue_ = value;
      }
    }

    /// <summary>Field number for the "doc" field.</summary>
    public const int DocFieldNumber = 5;
    private string doc_ = "";
    /// <summary>
    /// Documentation string
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Doc {
      get { return doc_; }
      set {
        doc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "normally_required" field.</summary>
    public const int NormallyRequiredFieldNumber = 6;
    private bool normallyRequired_;
    /// <summary>
    /// It is unusual for this field to be omitted
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NormallyRequired {
      get { return normallyRequired_; }
      set {
        normallyRequired_ = value;
      }
    }

    /// <summary>Field number for the "requires_configuration" field.</summary>
    public const int RequiresConfigurationFieldNumber = 7;
    private bool requiresConfiguration_;
    /// <summary>
    /// This field is often not set and is typically only specified if the user opts into it e.g. by configuring it
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RequiresConfiguration {
      get { return requiresConfiguration_; }
      set {
        requiresConfiguration_ = value;
      }
    }

    /// <summary>Field number for the "circumstantial_use" field.</summary>
    public const int CircumstantialUseFieldNumber = 8;
    private bool circumstantialUse_;
    /// <summary>
    /// This field is only used in specific circumstances e.g. when a particular publishing action occurs
    /// on a dashboard
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CircumstantialUse {
      get { return circumstantialUse_; }
      set {
        circumstantialUse_ = value;
      }
    }

    /// <summary>Field number for the "is_constrained_value" field.</summary>
    public const int IsConstrainedValueFieldNumber = 9;
    private bool isConstrainedValue_;
    /// <summary>
    /// The value of this field must be of a very specific range otherwise the product/feature will not behave as expected
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsConstrainedValue {
      get { return isConstrainedValue_; }
      set {
        isConstrainedValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SquaredUpFieldOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SquaredUpFieldOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsGuid != other.IsGuid) return false;
      if (ForPerspectivesOnly != other.ForPerspectivesOnly) return false;
      if (ForDashboardsOnly != other.ForDashboardsOnly) return false;
      if (IsUserValue != other.IsUserValue) return false;
      if (Doc != other.Doc) return false;
      if (NormallyRequired != other.NormallyRequired) return false;
      if (RequiresConfiguration != other.RequiresConfiguration) return false;
      if (CircumstantialUse != other.CircumstantialUse) return false;
      if (IsConstrainedValue != other.IsConstrainedValue) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsGuid != false) hash ^= IsGuid.GetHashCode();
      if (ForPerspectivesOnly != false) hash ^= ForPerspectivesOnly.GetHashCode();
      if (ForDashboardsOnly != false) hash ^= ForDashboardsOnly.GetHashCode();
      if (IsUserValue != false) hash ^= IsUserValue.GetHashCode();
      if (Doc.Length != 0) hash ^= Doc.GetHashCode();
      if (NormallyRequired != false) hash ^= NormallyRequired.GetHashCode();
      if (RequiresConfiguration != false) hash ^= RequiresConfiguration.GetHashCode();
      if (CircumstantialUse != false) hash ^= CircumstantialUse.GetHashCode();
      if (IsConstrainedValue != false) hash ^= IsConstrainedValue.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IsGuid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsGuid);
      }
      if (ForPerspectivesOnly != false) {
        output.WriteRawTag(16);
        output.WriteBool(ForPerspectivesOnly);
      }
      if (ForDashboardsOnly != false) {
        output.WriteRawTag(24);
        output.WriteBool(ForDashboardsOnly);
      }
      if (IsUserValue != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsUserValue);
      }
      if (Doc.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Doc);
      }
      if (NormallyRequired != false) {
        output.WriteRawTag(48);
        output.WriteBool(NormallyRequired);
      }
      if (RequiresConfiguration != false) {
        output.WriteRawTag(56);
        output.WriteBool(RequiresConfiguration);
      }
      if (CircumstantialUse != false) {
        output.WriteRawTag(64);
        output.WriteBool(CircumstantialUse);
      }
      if (IsConstrainedValue != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsConstrainedValue);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsGuid != false) {
        size += 1 + 1;
      }
      if (ForPerspectivesOnly != false) {
        size += 1 + 1;
      }
      if (ForDashboardsOnly != false) {
        size += 1 + 1;
      }
      if (IsUserValue != false) {
        size += 1 + 1;
      }
      if (Doc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Doc);
      }
      if (NormallyRequired != false) {
        size += 1 + 1;
      }
      if (RequiresConfiguration != false) {
        size += 1 + 1;
      }
      if (CircumstantialUse != false) {
        size += 1 + 1;
      }
      if (IsConstrainedValue != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SquaredUpFieldOptions other) {
      if (other == null) {
        return;
      }
      if (other.IsGuid != false) {
        IsGuid = other.IsGuid;
      }
      if (other.ForPerspectivesOnly != false) {
        ForPerspectivesOnly = other.ForPerspectivesOnly;
      }
      if (other.ForDashboardsOnly != false) {
        ForDashboardsOnly = other.ForDashboardsOnly;
      }
      if (other.IsUserValue != false) {
        IsUserValue = other.IsUserValue;
      }
      if (other.Doc.Length != 0) {
        Doc = other.Doc;
      }
      if (other.NormallyRequired != false) {
        NormallyRequired = other.NormallyRequired;
      }
      if (other.RequiresConfiguration != false) {
        RequiresConfiguration = other.RequiresConfiguration;
      }
      if (other.CircumstantialUse != false) {
        CircumstantialUse = other.CircumstantialUse;
      }
      if (other.IsConstrainedValue != false) {
        IsConstrainedValue = other.IsConstrainedValue;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IsGuid = input.ReadBool();
            break;
          }
          case 16: {
            ForPerspectivesOnly = input.ReadBool();
            break;
          }
          case 24: {
            ForDashboardsOnly = input.ReadBool();
            break;
          }
          case 32: {
            IsUserValue = input.ReadBool();
            break;
          }
          case 42: {
            Doc = input.ReadString();
            break;
          }
          case 48: {
            NormallyRequired = input.ReadBool();
            break;
          }
          case 56: {
            RequiresConfiguration = input.ReadBool();
            break;
          }
          case 64: {
            CircumstantialUse = input.ReadBool();
            break;
          }
          case 72: {
            IsConstrainedValue = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code