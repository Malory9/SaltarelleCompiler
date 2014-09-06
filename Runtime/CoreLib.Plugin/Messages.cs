﻿using System;
using Microsoft.CodeAnalysis;
using Saltarelle.Compiler;

namespace CoreLib.Plugin {
	public static class Messages {
		public static readonly Tuple<int, DiagnosticSeverity, string> _7001 = Tuple.Create(7001, DiagnosticSeverity.Error, "The type {0} has both [IgnoreNamespace] and [ScriptNamespace] specified. At most one of these attributes can be specified for a type.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7002 = Tuple.Create(7002, DiagnosticSeverity.Error, "{0}: The argument for [ScriptNamespace] must be a valid JavaScript qualified identifier, or be blank.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7003 = Tuple.Create(7003, DiagnosticSeverity.Error, "The type {0} cannot have a [ResourcesAttribute] because it is not static.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7004 = Tuple.Create(7004, DiagnosticSeverity.Error, "The type {0} cannot have a [ResourcesAttribute] because it is generic.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7005 = Tuple.Create(7005, DiagnosticSeverity.Error, "The type {0} cannot have a [ResourcesAttribute] because it contains members that are not const fields.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7006 = Tuple.Create(7006, DiagnosticSeverity.Error, "{0}: The argument for [ScriptName], when applied to a type, must be a valid JavaScript identifier (but can be empty if the type is in a module).");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7007 = Tuple.Create(7007, DiagnosticSeverity.Error, "[IgnoreNamespace] or [ScriptNamespace] cannot be specified for the nested type {0}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7009 = Tuple.Create(7009, DiagnosticSeverity.Error, "The serializable type {0} must inherit from another serializable type, System.Object or System.Record.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7010 = Tuple.Create(7010, DiagnosticSeverity.Error, "The serializable type {0} cannot implement the non-serializable interface {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7011 = Tuple.Create(7011, DiagnosticSeverity.Error, "The serializable type {0} cannot declare instance events.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7012 = Tuple.Create(7012, DiagnosticSeverity.Error, "The type {0} must be static in order to be decorated with a [MixinAttribute]");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7013 = Tuple.Create(7013, DiagnosticSeverity.Error, "The type {0} can contain only methods order to be decorated with a [MixinAttribute]");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7014 = Tuple.Create(7014, DiagnosticSeverity.Error, "[MixinAttribute] cannot be applied to the generic type {0}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7015 = Tuple.Create(7015, DiagnosticSeverity.Error, "The type {0} must be static in order to be decorated with a [GlobalMethodsAttribute]");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7017 = Tuple.Create(7017, DiagnosticSeverity.Error, "[GlobalMethodsAttribute] cannot be applied to the generic type {0}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7018 = Tuple.Create(7018, DiagnosticSeverity.Error, "The type {0} cannot inherit from both {1} and {2} because both those types have a member with the script name {3}. You have to rename the member on one of the base types, or refactor your code.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7023 = Tuple.Create(7023, DiagnosticSeverity.Error, "The serializable type {0} cannot declare the virtual member {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7024 = Tuple.Create(7024, DiagnosticSeverity.Error, "The serializable type {0} cannot override the member {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7025 = Tuple.Create(7025, DiagnosticSeverity.Error, "The argument to the [MixinAttribute] for the type {0} must not be null or empty.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7026 = Tuple.Create(7026, DiagnosticSeverity.Error, "The type {0} must have an [IncludeGenericArgumentsAttribute]");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7027 = Tuple.Create(7027, DiagnosticSeverity.Error, "The method {0} must have an [IncludeGenericArgumentsAttribute]");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7028 = Tuple.Create(7028, DiagnosticSeverity.Error, "The property {0} must have an [InlineCodeAttribute] on either both or none of its accessors because its declaring type is serializable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7029 = Tuple.Create(7029, DiagnosticSeverity.Error, "The {0} {1} cannot have a NonExpandedFormCode specified on its [InlineCodeAttribute] because it does not have a parameter with the 'params' modifier.");

		public static readonly Tuple<int, DiagnosticSeverity, string> _7100 = Tuple.Create(7100, DiagnosticSeverity.Error, "The member {0} has an [AlternateSignatureAttribute], but there is not exactly one other method with the same name that does not have that attribute.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7102 = Tuple.Create(7102, DiagnosticSeverity.Error, "The constructor {0} cannot have an [ExpandParamsAttribute] because it does not have a parameter with the 'params' modifier.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7103 = Tuple.Create(7103, DiagnosticSeverity.Error, "The inline code for the constructor {0} contained errors: {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7104 = Tuple.Create(7104, DiagnosticSeverity.Error, "The named specified in a [ScriptNameAttribute] for the indexer of type {0} cannot be empty.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7105 = Tuple.Create(7105, DiagnosticSeverity.Error, "The named specified in a [ScriptNameAttribute] for the property {0} cannot be empty.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7106 = Tuple.Create(7106, DiagnosticSeverity.Error, "Indexers cannot be decorated with [ScriptAliasAttribute].");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7107 = Tuple.Create(7107, DiagnosticSeverity.Error, "The property {0} cannot have a [ScriptAliasAttribute] because it is an instance member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7108 = Tuple.Create(7108, DiagnosticSeverity.Error, "The indexer cannot be decorated with [IntrinsicPropertyAttribute] because it is an interface member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7109 = Tuple.Create(7109, DiagnosticSeverity.Error, "The property {0} cannot have an [IntrinsicPropertyAttribute] because it is an interface member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7110 = Tuple.Create(7110, DiagnosticSeverity.Error, "The indexer be decorated with an [IntrinsicPropertyAttribute] because it overrides a base member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7111 = Tuple.Create(7111, DiagnosticSeverity.Error, "The property {0} cannot have an [IntrinsicPropertyAttribute] because it overrides a base member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7112 = Tuple.Create(7112, DiagnosticSeverity.Error, "The indexer cannot be decorated with an [IntrinsicPropertyAttribute] because it is overridable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7113 = Tuple.Create(7113, DiagnosticSeverity.Error, "The property {0} cannot have an [IntrinsicPropertyAttribute] because it is overridable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7114 = Tuple.Create(7114, DiagnosticSeverity.Error, "The indexer cannot be decorated with an [IntrinsicPropertyAttribute] because it implements an interface member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7115 = Tuple.Create(7115, DiagnosticSeverity.Error, "The property {0} cannot have an [IntrinsicPropertyAttribute] because it implements an interface member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7116 = Tuple.Create(7116, DiagnosticSeverity.Error, "Indexers with an [IntrinsicPropertyAttribute], and indexers on [Serializable] types, must have exactly one parameter.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7117 = Tuple.Create(7117, DiagnosticSeverity.Error, "The method {0} cannot have an [IntrinsicOperatorAttribute] because it is not an operator method.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7118 = Tuple.Create(7118, DiagnosticSeverity.Error, "The [IntrinsicOperatorAttribute] cannot be applied to the operator {0} because it is a conversion operator.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7119 = Tuple.Create(7119, DiagnosticSeverity.Error, "The method {0} cannot have a [ScriptSkipAttribute] because it is an interface method.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7120 = Tuple.Create(7120, DiagnosticSeverity.Error, "The member {0} cannot have a [ScriptSkipAttribute] because it overrides a base member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7121 = Tuple.Create(7121, DiagnosticSeverity.Error, "The member {0} cannot have a [ScriptSkipAttribute] because it is overridable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7122 = Tuple.Create(7122, DiagnosticSeverity.Error, "The member {0} cannot have a [ScriptSkipAttribute] because it implements an interface member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7123 = Tuple.Create(7123, DiagnosticSeverity.Error, "The static method {0} must have exactly one parameter in order to have a [ScriptSkipAttribute].");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7124 = Tuple.Create(7124, DiagnosticSeverity.Error, "The instance method {0} must have no parameters in order to have a [ScriptSkipAttribute].");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7125 = Tuple.Create(7125, DiagnosticSeverity.Error, "The method {0} must be static in order to have a [ScriptAliasAttribute].");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7126 = Tuple.Create(7126, DiagnosticSeverity.Error, "The member {0} needs a GeneratedMethodName property for its [InlineCodeAttribute] because it is an interface method.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7127 = Tuple.Create(7127, DiagnosticSeverity.Error, "The member {0} cannot have an [InlineCodeAttribute] because it overrides a base member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7128 = Tuple.Create(7128, DiagnosticSeverity.Error, "The member {0} cannot have an [InlineCodeAttribute] because it is overridable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7130 = Tuple.Create(7130, DiagnosticSeverity.Error, "The inline code for the method {0} contained errors: {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7131 = Tuple.Create(7131, DiagnosticSeverity.Error, "The method {0} cannot have an [InstanceMethodOnFirstArgumentAttribute] because it is not static.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7132 = Tuple.Create(7132, DiagnosticSeverity.Error, "The [ScriptName], [PreserveName] and [PreserveCase] attributes cannot be specified on method the method {0} because it overrides a base member. Specify the attribute on the base member instead.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7133 = Tuple.Create(7133, DiagnosticSeverity.Error, "The [IncludeGenericArguments] attribute cannot be specified on the method {0} because it overrides a base member. Specify the attribute on the base member instead.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7134 = Tuple.Create(7134, DiagnosticSeverity.Error, "The overriding member {0} cannot implement the interface method {1} because it has a different script name. Consider using explicit interface implementation.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7135 = Tuple.Create(7135, DiagnosticSeverity.Error, "The [ScriptName], [PreserveName], [PreserveCase] or [AlternateSignature] attributes cannot be specified on the method {0} because it implements an interface member. Specify the attribute on the interface member instead, or consider using explicit interface implementation.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7136 = Tuple.Create(7136, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because the interface member has the script name {2} and the member also implements an interface member with the script name {3}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7137 = Tuple.Create(7137, DiagnosticSeverity.Error, "The member {0} cannot have an [ExpandParamsAttribute] because it does not have a parameter with the 'params' modifier.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7138 = Tuple.Create(7138, DiagnosticSeverity.Error, "The member {0} cannot have an empty name specified in its [ScriptName] because it is an interface method.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7139 = Tuple.Create(7139, DiagnosticSeverity.Error, "The member {0} cannot have an empty name specified in its [ScriptName] because it is overridable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7141 = Tuple.Create(7141, DiagnosticSeverity.Error, "The named specified in a [ScriptNameAttribute] for the event {0} cannot be empty.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7142 = Tuple.Create(7142, DiagnosticSeverity.Error, "The named specified in a [ScriptNameAttribute] for the field {0} cannot be empty.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7143 = Tuple.Create(7143, DiagnosticSeverity.Error, "The type {0} doesn't contain a matching property or field for the constructor parameter {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7144 = Tuple.Create(7144, DiagnosticSeverity.Error, "The parameter {0} has the type {1} but the matching member has type {2}. The types must be the same.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7145 = Tuple.Create(7145, DiagnosticSeverity.Error, "The parameter {0} cannot be declared as ref or out.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7146 = Tuple.Create(7146, DiagnosticSeverity.Error, "The constructor cannot have an [ObjectLiteralAttribute] because the type {0} is not a serializable type.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7147 = Tuple.Create(7147, DiagnosticSeverity.Error, "The delegate type {0} cannot have a [BindThisToFirstParameterAttribute] because it does not have any parameters.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7148 = Tuple.Create(7148, DiagnosticSeverity.Error, "The delegate type {0} cannot have an [ExpandParamsAttribute] because it does not have a parameter with the 'params' modifier.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7149 = Tuple.Create(7149, DiagnosticSeverity.Error, "The method {0} cannot have an [InstanceMethodOnFirstArgumentAttribute] because it has no parameters.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7150 = Tuple.Create(7150, DiagnosticSeverity.Error, "The method {0} cannot have an [InstanceMethodOnFirstArgumentAttribute] because its only parameter is a 'params' array.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7151 = Tuple.Create(7151, DiagnosticSeverity.Error, "The method {0} cannot have an [EnumerateAsArrayAttribute] because it is not a GetEnumerator() method for the iterator pattern.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7152 = Tuple.Create(7152, DiagnosticSeverity.Error, "The field {0} cannot have an [InlineConstantAttribute] because it is not constant.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7153 = Tuple.Create(7153, DiagnosticSeverity.Error, "The property {0} cannot implement the property {1} because the property is declared by a serializable interface and the implementation is virtual.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7154 = Tuple.Create(7154, DiagnosticSeverity.Error, "The property {0} cannot implement the property {1} because the property is declared by a serializable interface and the implementation also overrides a base property.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7155 = Tuple.Create(7155, DiagnosticSeverity.Error, "The interface {0} cannot declare methods because it is serializable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7156 = Tuple.Create(7156, DiagnosticSeverity.Error, "The property {0} must be implemented as an auto-property because it implements the property {1} from a serializable interface.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7157 = Tuple.Create(7157, DiagnosticSeverity.Error, "The inline code for the type check for type {0} contained errors: {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7158 = Tuple.Create(7158, DiagnosticSeverity.Error, "Cannot specify both ObeysTypeSystem and TypeCheckCode on the [ImportedAttribute] for the type {0}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7159 = Tuple.Create(7159, DiagnosticSeverity.Error, "Cannot specify TypeCheckCode on the [SerializableAttribute] for the type {0} because it is imported. Specify the code on the [ImportedAttribute] instead.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7160 = Tuple.Create(7160, DiagnosticSeverity.Error, "The field {0} cannot have a [NoInlineAttribute] because it is not constant.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7161 = Tuple.Create(7161, DiagnosticSeverity.Error, "The interface {0} cannot declare indexers because it is serializable.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7162 = Tuple.Create(7162, DiagnosticSeverity.Error, "The value type (struct) {0} must be decorated with a [MutableAttribute] in order to declare instance auto-properties, instance auto events or non-readonly instance fields");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7163 = Tuple.Create(7163, DiagnosticSeverity.Error, "The custom initialization code for the member {0} contained errors: {1}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7164 = Tuple.Create(7164, DiagnosticSeverity.Error, "Custom initialization cannot be specified for the field {0} because it is const.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7165 = Tuple.Create(7165, DiagnosticSeverity.Error, "Custom initialization cannot be specified for the event {0} because it has a manual implementation and thus it doesn't have a backing field.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7166 = Tuple.Create(7166, DiagnosticSeverity.Error, "Custom initialization cannot be specified for the property {0} because it has a manual implementation and thus it doesn't have a backing field.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7167 = Tuple.Create(7167, DiagnosticSeverity.Error, "The property {0} cannot have a [BackingFieldNameAttribute] because it is not an automatically implemented property and thus it doesn't have a backing field.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7168 = Tuple.Create(7168, DiagnosticSeverity.Error, "The name specified in the [BackingFieldNameAttribute] for the property {0} must be a valid JavaScript identifier.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7169 = Tuple.Create(7169, DiagnosticSeverity.Error, "The event {0} cannot have a [BackingFieldNameAttribute] because it is not an automatically implemented event and thus it doesn't have a backing field.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7170 = Tuple.Create(7170, DiagnosticSeverity.Error, "The name specified in the [BackingFieldNameAttribute] for the event {0} must be a valid JavaScript identifier.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7171 = Tuple.Create(7171, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because the interface member has the script name {2} and the member is declared in a base type and has script name {3}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7172 = Tuple.Create(7172, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because the script name {2} is already used by another member.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7173 = Tuple.Create(7173, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because the member is specified to not generate any script output (it needs to generate a member with the script name {2}).");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7174 = Tuple.Create(7174, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because it is declared in a base type, and the interface member is implemented as {2} but the member is implemented as {3}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7175 = Tuple.Create(7175, DiagnosticSeverity.Error, "The member {0} cannot implement the interface member {1} because the interface member is implemented as {2} and the member also implements an interface member implemented as {3}.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7176 = Tuple.Create(7176, DiagnosticSeverity.Error, "The indexer cannot implement the interface indexer because the indexer is defined in a base class and is a native indexer.");

		public static readonly Tuple<int, DiagnosticSeverity, string> _7200 = Tuple.Create(7200, DiagnosticSeverity.Error, "This constructor for the type {0} cannot be used with reflection because it has a special implementation.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7201 = Tuple.Create(7201, DiagnosticSeverity.Error, "The {1} {0} cannot be used with reflection because it has a special implementation.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7202 = Tuple.Create(7202, DiagnosticSeverity.Error, "The {1} {0} cannot be used with reflection because its {2} has a special implementation.");

		public static readonly Tuple<int, DiagnosticSeverity, string> _7700 = Tuple.Create(7700, DiagnosticSeverity.Error, "Boxing of 'char' is not allowed because this is likely to cause undesired behaviour. Insert a cast to 'int' or 'string' to tell the compiler about the desired behaviour.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7701 = Tuple.Create(7701, DiagnosticSeverity.Error, "The type {0} cannot be used with the 'is' operator because there is no way to check its type.");
		public static readonly Tuple<int, DiagnosticSeverity, string> _7702 = Tuple.Create(7702, DiagnosticSeverity.Error, "The type {0} cannot be used with the 'as' operator because there is no way to check its type. Use a cast instead (which will be compiled to a no-op).");
	}
}
