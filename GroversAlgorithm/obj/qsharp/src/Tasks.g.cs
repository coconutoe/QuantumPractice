#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":50,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":52,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AllOnes\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":56,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AlternatingBits\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AlternatingBits\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":73,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_AlternatingBits\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":88,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":84}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":105,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Oracle_ArbitraryPattern\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":111,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Flip_Via_Pattern\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":114,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"queryRegister\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pattern\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"Flip_Via_Pattern\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":114,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"OracleConverter\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":132,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"OracleConverter\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":132,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"OracleConverterIm\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":137,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"markingOracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":89}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"OracleConverterIm\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":137,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"OracleConverterIm\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":137,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":5},\"Item2\":{\"Line\":2,\"Column\":8}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GroversAlgorithm.OracleConverterIm\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"HadamardTransform\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"HadamardTransform\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"HadamardTransform\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GroversAlgorithm.HadamardTransform\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"ConditionalPhaseFlip\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GroversAlgorithm.ConditionalPhaseFlip\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"GroverIteration\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GroversAlgorithm.GroverIteration\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":235,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"register\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"iterations\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":100}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"GroversSearch\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":235,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"E2E_GroversSearch_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":247,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"E2E_GroversSearch_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/GroversAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":247,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.GroversAlgorithm
{
    public partial class Oracle_AllOnes : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AllOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AllOnes";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.Oracle_AllOnes";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line 54 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((queryRegister, target));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AllOnes, (IQArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public partial class Oracle_AlternatingBits : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public Oracle_AlternatingBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_AlternatingBits";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.Oracle_AlternatingBits";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target) = __in__;
#line 75 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            var N = queryRegister.Length;
#line 76 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 77 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                if (((i % 2L) == 1L))
                {
#line 78 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(queryRegister[i]);
                }
            }

#line 81 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((queryRegister, target));
#line 82 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 83 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                if (((i % 2L) == 1L))
                {
#line 84 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(queryRegister[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target)
        {
            return __m__.Run<Oracle_AlternatingBits, (IQArray<Qubit>,Qubit), QVoid>((queryRegister, target));
        }
    }

    public partial class Oracle_ArbitraryPattern : Adjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>, ICallable
    {
        public Oracle_ArbitraryPattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ArbitraryPattern";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.Oracle_ArbitraryPattern";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid> Flip_Via_Pattern
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (queryRegister,target,pattern) = __in__;
#line 107 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            Flip_Via_Pattern.Apply((queryRegister, pattern));
#line 108 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Controlled.Apply((queryRegister, target));
#line 109 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            Flip_Via_Pattern.Apply((queryRegister, pattern));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.Flip_Via_Pattern = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid>>(typeof(Flip_Via_Pattern));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, Qubit target, IQArray<Boolean> pattern)
        {
            return __m__.Run<Oracle_ArbitraryPattern, (IQArray<Qubit>,Qubit,IQArray<Boolean>), QVoid>((queryRegister, target, pattern));
        }
    }

    public partial class Flip_Via_Pattern : Operation<(IQArray<Qubit>,IQArray<Boolean>), QVoid>, ICallable
    {
        public Flip_Via_Pattern(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Flip_Via_Pattern";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.Flip_Via_Pattern";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (queryRegister,pattern) = __in__;
#line 116 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (pattern.Length - 1L)))
#line hidden
            {
#line 117 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                if (!(pattern[i]))
                {
#line 118 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(queryRegister[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> queryRegister, IQArray<Boolean> pattern)
        {
            return __m__.Run<Flip_Via_Pattern, (IQArray<Qubit>,IQArray<Boolean>), QVoid>((queryRegister, pattern));
        }
    }

    public partial class OracleConverter : Function<IAdjointable, IAdjointable>, ICallable
    {
        public OracleConverter(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "OracleConverter";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.OracleConverter";
        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> OracleConverterIm
        {
            get;
            set;
        }

        public override Func<IAdjointable, IAdjointable> Body => (__in__) =>
        {
            var markingOracle = __in__;
#line 135 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            return OracleConverterIm.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (markingOracle, __arg1__)));
        }

        ;
        public override void Init()
        {
            this.OracleConverterIm = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(OracleConverterIm));
        }

        public override IApplyData __dataIn(IAdjointable data) => new QTuple<IAdjointable>(data);
        public override IApplyData __dataOut(IAdjointable data) => new QTuple<IAdjointable>(data);
        public static System.Threading.Tasks.Task<IAdjointable> Run(IOperationFactory __m__, IAdjointable markingOracle)
        {
            return __m__.Run<OracleConverter, IAdjointable, IAdjointable>(markingOracle);
        }
    }

    public partial class OracleConverterIm : Adjointable<(IAdjointable,IQArray<Qubit>)>, ICallable
    {
        public OracleConverterIm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IQArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "OracleConverterIm";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.OracleConverterIm";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line 140 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 141 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 142 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 143 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    markingOracle.Apply((register, q));
#line 146 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 147 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (markingOracle,register) = __in__;
#line hidden
            {
#line hidden
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(q);
#line hidden
                    markingOracle.Adjoint.Apply((register, q));
#line hidden
                    MicrosoftQuantumIntrinsicH.Adjoint.Apply(q);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IAdjointable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable markingOracle, IQArray<Qubit> register)
        {
            return __m__.Run<OracleConverterIm, (IAdjointable,IQArray<Qubit>), QVoid>((markingOracle, register));
        }
    }

    public partial class HadamardTransform : Adjointable<IQArray<Qubit>>, ICallable
    {
        public HadamardTransform(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HadamardTransform";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.HadamardTransform";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 164 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var qs in register)
#line hidden
            {
#line 165 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var register = __in__;
#line hidden
            foreach (var qs in register?.Slice(new Range((register.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<HadamardTransform, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class ConditionalPhaseFlip : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ConditionalPhaseFlip(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ConditionalPhaseFlip";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.ConditionalPhaseFlip";
        protected ICallable Length
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var register = __in__;
#line 185 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var qs in register)
#line hidden
            {
#line 186 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs);
            }

#line hidden
            {
#line 188 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 189 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 190 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicZ.Controlled.Apply((register, q));
#line 191 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line 194 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var qs in register)
#line hidden
            {
#line 195 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var register = __in__;
#line hidden
            foreach (var qs in register?.Slice(new Range((register.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs);
            }

#line hidden
            {
#line hidden
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
#line hidden
                    MicrosoftQuantumIntrinsicZ.Controlled.Adjoint.Apply((register, q));
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(q);
                }
            }

#line hidden
            foreach (var qs in register?.Slice(new Range((register.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register)
        {
            return __m__.Run<ConditionalPhaseFlip, IQArray<Qubit>, QVoid>(register);
        }
    }

    public partial class GroverIteration : Adjointable<(IQArray<Qubit>,IAdjointable)>, ICallable
    {
        public GroverIteration(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroverIteration";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.GroverIteration";
        protected IAdjointable<IQArray<Qubit>> ConditionalPhaseFlip
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (register,oracle) = __in__;
#line 211 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            oracle.Apply(register);
#line 213 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            HadamardTransform.Apply(register);
#line 215 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            ConditionalPhaseFlip.Apply(register);
#line 217 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            HadamardTransform.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (register,oracle) = __in__;
#line hidden
            HadamardTransform.Adjoint.Apply(register);
#line hidden
            ConditionalPhaseFlip.Adjoint.Apply(register);
#line hidden
            HadamardTransform.Adjoint.Apply(register);
#line hidden
            oracle.Adjoint.Apply(register);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ConditionalPhaseFlip = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ConditionalPhaseFlip));
            this.HadamardTransform = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IAdjointable oracle)
        {
            return __m__.Run<GroverIteration, (IQArray<Qubit>,IAdjointable), QVoid>((register, oracle));
        }
    }

    public partial class GroversSearch : Operation<(IQArray<Qubit>,IAdjointable,Int64), QVoid>, ICallable
    {
        public GroversSearch(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "GroversSearch";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.GroversSearch";
        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> GroverIteration
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (register,oracle,iterations) = __in__;
#line 237 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            HadamardTransform.Apply(register);
#line 238 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (iterations - 1L)))
#line hidden
            {
#line 239 "G:\\QuantumPractice\\quantumKatas-VS\\GroversAlgorithm\\Tasks.qs"
                GroverIteration.Apply((register, OracleConverter.Apply(oracle)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GroverIteration = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(GroverIteration));
            this.HadamardTransform = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform));
            this.OracleConverter = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> register, IAdjointable oracle, Int64 iterations)
        {
            return __m__.Run<GroversSearch, (IQArray<Qubit>,IAdjointable,Int64), QVoid>((register, oracle, iterations));
        }
    }

    public partial class E2E_GroversSearch_Test : Operation<QVoid, QVoid>, ICallable
    {
        public E2E_GroversSearch_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "E2E_GroversSearch_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.E2E_GroversSearch_Test";
        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<E2E_GroversSearch_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}