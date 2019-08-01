#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"InitializeQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"InitializeQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ZeroZeroOrOneOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ZeroZeroOrOneOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BasisStateMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BasisStateMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"AllZerosOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":166,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"AllZerosOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":166,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":185,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":185,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":264,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":264,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":292,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":292,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusOrZero\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":314,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusOrZero\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":314,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusZeroOrInconclusiveSimpleUSD\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusZeroOrInconclusiveSimpleUSD\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitNotInABC\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitNotInABC\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tasks.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Measurements
{
    public partial class IsQubitOne : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitOne";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitOne";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<Qubit, Boolean> Body => (__in__) =>
        {
            var q = __in__;
#line 51 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return (MicrosoftQuantumIntrinsicM.Apply(q) == Result.One);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitOne, Qubit, Boolean>(q);
        }
    }

    public partial class InitializeQubit : Operation<Qubit, QVoid>, ICallable
    {
        public InitializeQubit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "InitializeQubit";
        String ICallable.FullName => "Quantum.Kata.Measurements.InitializeQubit";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 59 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var result = MicrosoftQuantumIntrinsicM.Apply(q);
#line 60 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if ((result == Result.One))
            {
#line 61 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<InitializeQubit, Qubit, QVoid>(q);
        }
    }

    public partial class IsQubitPlus : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitPlus(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlus";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlus";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<Qubit, Boolean> Body => (__in__) =>
        {
            var q = __in__;
#line 72 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(q);
#line 73 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var result = MicrosoftQuantumIntrinsicM.Apply(q);
#line 74 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return (result == Result.Zero);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitPlus, Qubit, Boolean>(q);
        }
    }

    public partial class IsQubitA : Operation<(Double,Qubit), Boolean>, ICallable
    {
        public IsQubitA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Qubit)>, IApplyData
        {
            public In((Double,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "IsQubitA";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitA";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        public override Func<(Double,Qubit), Boolean> Body => (__in__) =>
        {
            var (alpha,q) = __in__;
#line 87 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((-(2D) * alpha), q));
#line 88 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var result = MicrosoftQuantumIntrinsicM.Apply(q);
#line 90 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return (result == Result.Zero);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
        }

        public override IApplyData __dataIn((Double,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Double alpha, Qubit q)
        {
            return __m__.Run<IsQubitA, (Double,Qubit), Boolean>((alpha, q));
        }
    }

    public partial class ZeroZeroOrOneOne : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ZeroZeroOrOneOne(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ZeroZeroOrOneOne";
        String ICallable.FullName => "Quantum.Kata.Measurements.ZeroZeroOrOneOne";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 100 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var result = MicrosoftQuantumIntrinsicM.Apply(qs[0L]);
#line 101 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if ((result == Result.Zero))
            {
#line 102 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                return 0L;
            }

#line 104 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return 1L;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ZeroZeroOrOneOne, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class BasisStateMeasurement : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public BasisStateMeasurement(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BasisStateMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.BasisStateMeasurement";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 120 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var r1 = ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == Result.Zero) ? 0L : 1L);
#line 121 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var r2 = ((MicrosoftQuantumIntrinsicM.Apply(qs[1L]) == Result.Zero) ? 0L : 1L);
#line 122 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return ((2L * r1) + r2);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<BasisStateMeasurement, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class TwoBitstringsMeasurement : Operation<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64>, ICallable
    {
        public TwoBitstringsMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "TwoBitstringsMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoBitstringsMeasurement";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64> Body => (__in__) =>
        {
            var (qs,bits1,bits2) = __in__;
#line 142 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var N = qs.Length;
#line 143 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var j = 0L;
#line 145 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            while (true)
            {
#line 146 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                j = (j + 1L);
                if ((bits1[j] != bits2[j]))
                {
                    break;
                }
                else
                {
                }
            }

#line 148 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var b = false;
#line 149 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if ((MicrosoftQuantumIntrinsicM.Apply(qs[j]) == Result.One))
            {
#line 150 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                b = true;
            }

#line 153 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if ((b == bits1[j]))
            {
#line 154 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                return 0L;
            }

#line 156 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return 1L;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits1, IQArray<Boolean> bits2)
        {
            return __m__.Run<TwoBitstringsMeasurement, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64>((qs, bits1, bits2));
        }
    }

    public partial class AllZerosOrWState : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public AllZerosOrWState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AllZerosOrWState";
        String ICallable.FullName => "Quantum.Kata.Measurements.AllZerosOrWState";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 169 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            foreach (var i in new Range(0L, (qs.Length - 1L)))
#line hidden
            {
#line 170 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                var re = MicrosoftQuantumIntrinsicM.Apply(qs[i]);
#line 171 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                if ((re != Result.Zero))
                {
#line 172 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                    return 1L;
                }
            }

#line 175 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<AllZerosOrWState, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrWState : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrWState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrWState";
        String ICallable.FullName => "Quantum.Kata.Measurements.GHZOrWState";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 188 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var k = 0L;
#line 189 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            foreach (var i in new Range(0L, (qs.Length - 1L)))
#line hidden
            {
#line 190 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                var result = MicrosoftQuantumIntrinsicM.Apply(qs[i]);
#line 191 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                if ((result == Result.One))
                {
#line 192 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                    k = (k + 1L);
                }
            }

#line 196 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return ((k == 1L) ? 1L : 0L);
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<GHZOrWState, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class BellState : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public BellState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellState";
        String ICallable.FullName => "Quantum.Kata.Measurements.BellState";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 212 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 213 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 214 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res1 = MicrosoftQuantumIntrinsicM.Apply(qs[0L]);
#line 215 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res2 = MicrosoftQuantumIntrinsicM.Apply(qs[1L]);
#line 216 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var retValue = 0L;
#line 217 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if (((res1 == Result.One) && (res2 == Result.Zero)))
            {
#line 218 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 1L;
            }
            else if (((res1 == Result.Zero) && (res2 == Result.One)))
            {
#line 220 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 2L;
            }
            else if (((res1 == Result.One) && (res2 == Result.One)))
            {
#line 222 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 3L;
            }

#line 224 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return retValue;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<BellState, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class TwoQubitState : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public TwoQubitState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitState";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoQubitState";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 240 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res1 = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliX), new QArray<Qubit>(qs[0L])));
#line 241 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res2 = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliX), new QArray<Qubit>(qs[1L])));
#line 242 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var retValue = 0L;
#line 243 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if (((res1 == Result.Zero) && (res2 == Result.One)))
            {
#line 244 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 1L;
            }
            else if (((res1 == Result.One) && (res2 == Result.Zero)))
            {
#line 246 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 2L;
            }
            else if (((res1 == Result.One) && (res2 == Result.One)))
            {
#line 248 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 3L;
            }

#line 250 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return retValue;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitState, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class TwoQubitStatePartTwo : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public TwoQubitStatePartTwo(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitStatePartTwo";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoQubitStatePartTwo";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 266 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 267 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 268 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 270 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res1 = MicrosoftQuantumIntrinsicM.Apply(qs[0L]);
#line 271 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var res2 = MicrosoftQuantumIntrinsicM.Apply(qs[1L]);
#line 272 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var retValue = 0L;
#line 273 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if (((res1 == Result.Zero) && (res2 == Result.One)))
            {
#line 274 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 1L;
            }
            else if (((res1 == Result.One) && (res2 == Result.Zero)))
            {
#line 276 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 2L;
            }
            else if (((res1 == Result.Zero) && (res2 == Result.Zero)))
            {
#line 278 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                retValue = 3L;
            }

#line 280 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return retValue;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitStatePartTwo, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ThreeQubitMeasurement : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ThreeQubitMeasurement(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ThreeQubitMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.ThreeQubitMeasurement";
        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 295 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ThreeQubitMeasurement, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class IsQubitPlusOrZero : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitPlusOrZero(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlusOrZero";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlusOrZero";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        public override Func<Qubit, Boolean> Body => (__in__) =>
        {
            var q = __in__;
#line 316 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 4D), q));
#line 317 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            var re = MicrosoftQuantumIntrinsicM.Apply(q);
#line 318 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            if ((re == Result.Zero))
            {
#line 319 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
                return true;
            }

#line 321 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return false;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitPlusOrZero, Qubit, Boolean>(q);
        }
    }

    public partial class IsQubitPlusZeroOrInconclusiveSimpleUSD : Operation<Qubit, Int64>, ICallable
    {
        public IsQubitPlusZeroOrInconclusiveSimpleUSD(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlusZeroOrInconclusiveSimpleUSD";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlusZeroOrInconclusiveSimpleUSD";
        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 341 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return -(2L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitPlusZeroOrInconclusiveSimpleUSD, Qubit, Int64>(q);
        }
    }

    public partial class IsQubitNotInABC : Operation<Qubit, Int64>, ICallable
    {
        public IsQubitNotInABC(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitNotInABC";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitNotInABC";
        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 360 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tasks.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitNotInABC, Qubit, Int64>(q);
        }
    }
}