// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: visio.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SquaredUp.Dashboard.Schema {

  /// <summary>Holder for reflection information generated from visio.proto</summary>
  public static partial class VisioReflection {

    #region Descriptor
    /// <summary>File descriptor for visio.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VisioReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgt2aXNpby5wcm90bxIJc3F1YXJlZHVwGhxnb29nbGUvcHJvdG9idWYvc3Ry",
            "dWN0LnByb3RvGgtzY29wZS5wcm90bxoNY29udGV4dC5wcm90byKkAQoPVmlz",
            "aW9UaWxlQ29uZmlnEikKB2NvbnRleHQYASABKAsyGC5zcXVhcmVkdXAuQ29t",
            "bW9uQ29udGV4dBIxCgZzb3VyY2UYAiABKAsyIS5zcXVhcmVkdXAuVmlzaW9U",
            "aWxlQ29uZmlnX1NvdXJjZRIzCgdkaXNwbGF5GAMgASgLMiIuc3F1YXJlZHVw",
            "LlZpc2lvVGlsZUNvbmZpZ19EaXNwbGF5Ij8KFlZpc2lvVGlsZUNvbmZpZ19T",
            "b3VyY2USJQoFc2NvcGUYASABKAsyFi5zcXVhcmVkdXAuQ29tbW9uU2NvcGUi",
            "mwEKF1Zpc2lvVGlsZUNvbmZpZ19EaXNwbGF5EhAKCGJlaGF2aW9yGAEgASgJ",
            "EhUKDWljb25wb3NpdGlvbngYAiABKAkSFQoNaWNvbnBvc2l0aW9ueRgDIAEo",
            "CRIQCghpY29uc2l6ZRgEIAEoARIMCgRwYXRoGAUgASgJEhIKCmNvbG9ybWF0",
            "Y2gYBiABKAkSDAoEem9vbRgHIAEoCUIdqgIaU3F1YXJlZFVwLkRhc2hib2Fy",
            "ZC5TY2hlbWFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::SquaredUp.Dashboard.Schema.ScopeReflection.Descriptor, global::SquaredUp.Dashboard.Schema.ContextReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SquaredUp.Dashboard.Schema.VisioTileConfig), global::SquaredUp.Dashboard.Schema.VisioTileConfig.Parser, new[]{ "Context", "Source", "Display" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source), global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source.Parser, new[]{ "Scope" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display), global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display.Parser, new[]{ "Behavior", "Iconpositionx", "Iconpositiony", "Iconsize", "Path", "Colormatch", "Zoom" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VisioTileConfig : pb::IMessage<VisioTileConfig> {
    private static readonly pb::MessageParser<VisioTileConfig> _parser = new pb::MessageParser<VisioTileConfig>(() => new VisioTileConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VisioTileConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SquaredUp.Dashboard.Schema.VisioReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig(VisioTileConfig other) : this() {
      Context = other.context_ != null ? other.Context.Clone() : null;
      Source = other.source_ != null ? other.Source.Clone() : null;
      Display = other.display_ != null ? other.Display.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig Clone() {
      return new VisioTileConfig(this);
    }

    /// <summary>Field number for the "context" field.</summary>
    public const int ContextFieldNumber = 1;
    private global::SquaredUp.Dashboard.Schema.CommonContext context_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SquaredUp.Dashboard.Schema.CommonContext Context {
      get { return context_; }
      set {
        context_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 2;
    private global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "display" field.</summary>
    public const int DisplayFieldNumber = 3;
    private global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display display_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display Display {
      get { return display_; }
      set {
        display_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VisioTileConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VisioTileConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Context, other.Context)) return false;
      if (!object.Equals(Source, other.Source)) return false;
      if (!object.Equals(Display, other.Display)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (context_ != null) hash ^= Context.GetHashCode();
      if (source_ != null) hash ^= Source.GetHashCode();
      if (display_ != null) hash ^= Display.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (context_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Context);
      }
      if (source_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Source);
      }
      if (display_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Display);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (context_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Context);
      }
      if (source_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Source);
      }
      if (display_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Display);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VisioTileConfig other) {
      if (other == null) {
        return;
      }
      if (other.context_ != null) {
        if (context_ == null) {
          context_ = new global::SquaredUp.Dashboard.Schema.CommonContext();
        }
        Context.MergeFrom(other.Context);
      }
      if (other.source_ != null) {
        if (source_ == null) {
          source_ = new global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source();
        }
        Source.MergeFrom(other.Source);
      }
      if (other.display_ != null) {
        if (display_ == null) {
          display_ = new global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display();
        }
        Display.MergeFrom(other.Display);
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
          case 10: {
            if (context_ == null) {
              context_ = new global::SquaredUp.Dashboard.Schema.CommonContext();
            }
            input.ReadMessage(context_);
            break;
          }
          case 18: {
            if (source_ == null) {
              source_ = new global::SquaredUp.Dashboard.Schema.VisioTileConfig_Source();
            }
            input.ReadMessage(source_);
            break;
          }
          case 26: {
            if (display_ == null) {
              display_ = new global::SquaredUp.Dashboard.Schema.VisioTileConfig_Display();
            }
            input.ReadMessage(display_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class VisioTileConfig_Source : pb::IMessage<VisioTileConfig_Source> {
    private static readonly pb::MessageParser<VisioTileConfig_Source> _parser = new pb::MessageParser<VisioTileConfig_Source>(() => new VisioTileConfig_Source());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VisioTileConfig_Source> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SquaredUp.Dashboard.Schema.VisioReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Source() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Source(VisioTileConfig_Source other) : this() {
      Scope = other.scope_ != null ? other.Scope.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Source Clone() {
      return new VisioTileConfig_Source(this);
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 1;
    private global::SquaredUp.Dashboard.Schema.CommonScope scope_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::SquaredUp.Dashboard.Schema.CommonScope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VisioTileConfig_Source);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VisioTileConfig_Source other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Scope, other.Scope)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (scope_ != null) hash ^= Scope.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (scope_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Scope);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (scope_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Scope);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VisioTileConfig_Source other) {
      if (other == null) {
        return;
      }
      if (other.scope_ != null) {
        if (scope_ == null) {
          scope_ = new global::SquaredUp.Dashboard.Schema.CommonScope();
        }
        Scope.MergeFrom(other.Scope);
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
          case 10: {
            if (scope_ == null) {
              scope_ = new global::SquaredUp.Dashboard.Schema.CommonScope();
            }
            input.ReadMessage(scope_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class VisioTileConfig_Display : pb::IMessage<VisioTileConfig_Display> {
    private static readonly pb::MessageParser<VisioTileConfig_Display> _parser = new pb::MessageParser<VisioTileConfig_Display>(() => new VisioTileConfig_Display());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VisioTileConfig_Display> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SquaredUp.Dashboard.Schema.VisioReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Display() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Display(VisioTileConfig_Display other) : this() {
      behavior_ = other.behavior_;
      iconpositionx_ = other.iconpositionx_;
      iconpositiony_ = other.iconpositiony_;
      iconsize_ = other.iconsize_;
      path_ = other.path_;
      colormatch_ = other.colormatch_;
      zoom_ = other.zoom_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VisioTileConfig_Display Clone() {
      return new VisioTileConfig_Display(this);
    }

    /// <summary>Field number for the "behavior" field.</summary>
    public const int BehaviorFieldNumber = 1;
    private string behavior_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Behavior {
      get { return behavior_; }
      set {
        behavior_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iconpositionx" field.</summary>
    public const int IconpositionxFieldNumber = 2;
    private string iconpositionx_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Iconpositionx {
      get { return iconpositionx_; }
      set {
        iconpositionx_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iconpositiony" field.</summary>
    public const int IconpositionyFieldNumber = 3;
    private string iconpositiony_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Iconpositiony {
      get { return iconpositiony_; }
      set {
        iconpositiony_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "iconsize" field.</summary>
    public const int IconsizeFieldNumber = 4;
    private double iconsize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Iconsize {
      get { return iconsize_; }
      set {
        iconsize_ = value;
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 5;
    private string path_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "colormatch" field.</summary>
    public const int ColormatchFieldNumber = 6;
    private string colormatch_ = "";
    /// <summary>
    /// Comma-separate hex codes of colour for matching
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Colormatch {
      get { return colormatch_; }
      set {
        colormatch_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "zoom" field.</summary>
    public const int ZoomFieldNumber = 7;
    private string zoom_ = "";
    /// <summary>
    /// e.g. 'column'
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Zoom {
      get { return zoom_; }
      set {
        zoom_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VisioTileConfig_Display);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VisioTileConfig_Display other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Behavior != other.Behavior) return false;
      if (Iconpositionx != other.Iconpositionx) return false;
      if (Iconpositiony != other.Iconpositiony) return false;
      if (Iconsize != other.Iconsize) return false;
      if (Path != other.Path) return false;
      if (Colormatch != other.Colormatch) return false;
      if (Zoom != other.Zoom) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Behavior.Length != 0) hash ^= Behavior.GetHashCode();
      if (Iconpositionx.Length != 0) hash ^= Iconpositionx.GetHashCode();
      if (Iconpositiony.Length != 0) hash ^= Iconpositiony.GetHashCode();
      if (Iconsize != 0D) hash ^= Iconsize.GetHashCode();
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (Colormatch.Length != 0) hash ^= Colormatch.GetHashCode();
      if (Zoom.Length != 0) hash ^= Zoom.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Behavior.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Behavior);
      }
      if (Iconpositionx.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Iconpositionx);
      }
      if (Iconpositiony.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Iconpositiony);
      }
      if (Iconsize != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Iconsize);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Path);
      }
      if (Colormatch.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Colormatch);
      }
      if (Zoom.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Zoom);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Behavior.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Behavior);
      }
      if (Iconpositionx.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Iconpositionx);
      }
      if (Iconpositiony.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Iconpositiony);
      }
      if (Iconsize != 0D) {
        size += 1 + 8;
      }
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (Colormatch.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Colormatch);
      }
      if (Zoom.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Zoom);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VisioTileConfig_Display other) {
      if (other == null) {
        return;
      }
      if (other.Behavior.Length != 0) {
        Behavior = other.Behavior;
      }
      if (other.Iconpositionx.Length != 0) {
        Iconpositionx = other.Iconpositionx;
      }
      if (other.Iconpositiony.Length != 0) {
        Iconpositiony = other.Iconpositiony;
      }
      if (other.Iconsize != 0D) {
        Iconsize = other.Iconsize;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.Colormatch.Length != 0) {
        Colormatch = other.Colormatch;
      }
      if (other.Zoom.Length != 0) {
        Zoom = other.Zoom;
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
          case 10: {
            Behavior = input.ReadString();
            break;
          }
          case 18: {
            Iconpositionx = input.ReadString();
            break;
          }
          case 26: {
            Iconpositiony = input.ReadString();
            break;
          }
          case 33: {
            Iconsize = input.ReadDouble();
            break;
          }
          case 42: {
            Path = input.ReadString();
            break;
          }
          case 50: {
            Colormatch = input.ReadString();
            break;
          }
          case 58: {
            Zoom = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
