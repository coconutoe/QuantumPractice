#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitOne_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitOne_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"InitializeQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"InitializeQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlus_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlus_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitA_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitA_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ZeroZeroOrOneOne_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ZeroZeroOrOneOne_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BasisStateMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BasisStateMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"FindFirstDiff_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"FindFirstDiff_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoBitstringsMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoBitstringsMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":119,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"AllZerosOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"AllZerosOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BellState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"BellState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":237,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":237,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ApplyDiag\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":24}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ApplyDiag\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":261,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ApplyDiag\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":267,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo_Alternate\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"TwoQubitStatePartTwo_Alternate\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":291,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":291,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement_SimpleMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":346,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":50}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ThreeQubitMeasurement_SimpleMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":346,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":50}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusOrZero_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":370,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusOrZero_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":370,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":411,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":59}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":411,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":59}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitNotInABC_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":465,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"IsQubitNotInABC_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":465,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Measurements
{
    public partial class IsQubitOne_Reference : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitOne_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitOne_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitOne_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<Qubit, Boolean> Body => (__in__) =>
        {
            var q = __in__;
#line 29 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
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
            return __m__.Run<IsQubitOne_Reference, Qubit, Boolean>(q);
        }
    }

    public partial class InitializeQubit_Reference : Operation<Qubit, QVoid>, ICallable
    {
        public InitializeQubit_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "InitializeQubit_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.InitializeQubit_Reference";
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
#line 35 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            if ((MicrosoftQuantumIntrinsicM.Apply(q) == Result.One))
            {
#line 36 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
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
            return __m__.Run<InitializeQubit_Reference, Qubit, QVoid>(q);
        }
    }

    public partial class IsQubitPlus_Reference : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitPlus_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlus_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlus_Reference";
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
#line 47 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(q);
#line 48 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return (MicrosoftQuantumIntrinsicM.Apply(q) == Result.Zero);
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
            return __m__.Run<IsQubitPlus_Reference, Qubit, Boolean>(q);
        }
    }

    public partial class IsQubitA_Reference : Operation<(Double,Qubit), Boolean>, ICallable
    {
        public IsQubitA_Reference(IOperationFactory m) : base(m)
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

        String ICallable.Name => "IsQubitA_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitA_Reference";
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
#line 63 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((-(2D) * alpha), q));
#line 64 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return (MicrosoftQuantumIntrinsicM.Apply(q) == Result.Zero);
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
            return __m__.Run<IsQubitA_Reference, (Double,Qubit), Boolean>((alpha, q));
        }
    }

    public partial class ZeroZeroOrOneOne_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ZeroZeroOrOneOne_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ZeroZeroOrOneOne_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.ZeroZeroOrOneOne_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 75 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == Result.Zero) ? 0L : 1L);
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
            return __m__.Run<ZeroZeroOrOneOne_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class BasisStateMeasurement_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public BasisStateMeasurement_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BasisStateMeasurement_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.BasisStateMeasurement_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 90 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m1 = ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == Result.Zero) ? 0L : 1L);
#line 91 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m2 = ((MicrosoftQuantumIntrinsicM.Apply(qs[1L]) == Result.Zero) ? 0L : 1L);
#line 92 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((m1 * 2L) + m2);
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
            return __m__.Run<BasisStateMeasurement_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class FindFirstDiff_Reference : Function<(IQArray<Boolean>,IQArray<Boolean>), Int64>, ICallable
    {
        public FindFirstDiff_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "FindFirstDiff_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.FindFirstDiff_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>), Int64> Body => (__in__) =>
        {
            var (bits1,bits2) = __in__;
#line 111 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            foreach (var i in new Range(0L, (bits1.Length - 1L)))
#line hidden
            {
#line 112 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                if ((bits1[i] != bits2[i]))
                {
#line 113 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    return i;
                }
            }

#line 116 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return -(1L);
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Boolean> bits1, IQArray<Boolean> bits2)
        {
            return __m__.Run<FindFirstDiff_Reference, (IQArray<Boolean>,IQArray<Boolean>), Int64>((bits1, bits2));
        }
    }

    public partial class TwoBitstringsMeasurement_Reference : Operation<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64>, ICallable
    {
        public TwoBitstringsMeasurement_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "TwoBitstringsMeasurement_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoBitstringsMeasurement_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64> FindFirstDiff_Reference
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64> Body => (__in__) =>
        {
            var (qs,bits1,bits2) = __in__;
#line 122 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var firstDiff = FindFirstDiff_Reference.Apply((bits1, bits2));
#line 123 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var res = (MicrosoftQuantumIntrinsicM.Apply(qs[firstDiff]) == Result.One);
#line 125 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((res == bits1[firstDiff]) ? 0L : 1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.FindFirstDiff_Reference = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64>>(typeof(FindFirstDiff_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits1, IQArray<Boolean> bits2)
        {
            return __m__.Run<TwoBitstringsMeasurement_Reference, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64>((qs, bits1, bits2));
        }
    }

    public partial class AllZerosOrWState_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public AllZerosOrWState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AllZerosOrWState_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.AllZerosOrWState_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 139 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var countOnes = 0L;
#line 141 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            foreach (var q in qs)
#line hidden
            {
#line 142 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                if ((MicrosoftQuantumIntrinsicM.Apply(q) == Result.One))
                {
#line 143 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    countOnes = (countOnes + 1L);
                }
            }

#line 147 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            if ((countOnes > 1L))
            {
#line 148 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                throw new ExecutionFailException("Impossible to get multiple Ones when measuring W state");
            }

#line 150 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((countOnes == 0L) ? 0L : 1L);
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
            return __m__.Run<AllZerosOrWState_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrWState_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrWState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrWState_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.GHZOrWState_Reference";
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
#line 165 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var countOnes = 0L;
#line 167 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            foreach (var q in qs)
#line hidden
            {
#line 168 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                if ((MicrosoftQuantumIntrinsicM.Apply(q) == Result.One))
                {
#line 169 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    countOnes = (countOnes + 1L);
                }
            }

#line 173 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var N = qs.Length;
#line 174 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            if (((countOnes > 1L) && (countOnes < N)))
            {
#line 175 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                throw new ExecutionFailException(String.Format("Impossible to get {0} Ones when measuring W state or GHZ state on {1} qubits", countOnes, N));
            }

#line 177 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((countOnes == 1L) ? 1L : 0L);
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
            return __m__.Run<GHZOrWState_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class BellState_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public BellState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellState_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.BellState_Reference";
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
#line 193 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 194 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 195 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[1L], qs[0L]));
#line 196 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 199 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m1 = ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == Result.Zero) ? 0L : 1L);
#line 200 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m2 = ((MicrosoftQuantumIntrinsicM.Apply(qs[1L]) == Result.Zero) ? 0L : 1L);
#line 201 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((m2 * 2L) + m1);
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
            return __m__.Run<BellState_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class TwoQubitState_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public TwoQubitState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitState_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoQubitState_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> BasisStateMeasurement_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 220 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 221 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 222 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return BasisStateMeasurement_Reference.Apply(qs);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.BasisStateMeasurement_Reference = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(BasisStateMeasurement_Reference));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitState_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class TwoQubitStatePartTwo_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public TwoQubitStatePartTwo_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitStatePartTwo_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoQubitStatePartTwo_Reference";
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
#line 240 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 251 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 252 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 254 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m1 = ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == Result.One) ? 0L : 1L);
#line 255 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var m2 = ((MicrosoftQuantumIntrinsicM.Apply(qs[1L]) == Result.One) ? 0L : 1L);
#line 256 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((m2 * 2L) + m1);
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
            return __m__.Run<TwoQubitStatePartTwo_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ApplyDiag : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ApplyDiag(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ApplyDiag";
        String ICallable.FullName => "Quantum.Kata.Measurements.ApplyDiag";
        protected ICallable MicrosoftQuantumCanonApplyToEach
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
            var qs = __in__;
#line 263 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line 264 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line 265 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ApplyDiag, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class TwoQubitStatePartTwo_Alternate : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public TwoQubitStatePartTwo_Alternate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TwoQubitStatePartTwo_Alternate";
        String ICallable.FullName => "Quantum.Kata.Measurements.TwoQubitStatePartTwo_Alternate";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonWith
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ApplyDiag
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> BasisStateMeasurement_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 282 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicSWAP.Apply((qs[0L], qs[1L]));
#line 285 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonWith.Apply((ApplyDiag, MicrosoftQuantumCanonApplyToEach.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg1__) => (MicrosoftQuantumIntrinsicH, __arg1__))), qs));
#line 286 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return BasisStateMeasurement_Reference.Apply(qs);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumCanonWith = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.With<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.ApplyDiag = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ApplyDiag));
            this.BasisStateMeasurement_Reference = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(BasisStateMeasurement_Reference));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TwoQubitStatePartTwo_Alternate, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ThreeQubitMeasurement_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ThreeQubitMeasurement_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ThreeQubitMeasurement_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.ThreeQubitMeasurement_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRz
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 311 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var result = 0L;
#line 314 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRz.Apply((((4D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
#line 317 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRz.Apply((((8D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
#line 320 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            WState_Arbitrary_Reference.Adjoint.Apply(qs);
#line hidden
            {
#line 323 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                var anc = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 325 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumIntrinsicX)).Apply((qs, anc));
#line 326 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    result = ((MicrosoftQuantumMeasurementMResetZ.Apply(anc) == Result.One) ? 0L : 1L);
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
                    Release.Apply(anc);
                }
            }

#line 333 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            WState_Arbitrary_Reference.Apply(qs);
#line 336 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRz.Apply((((-(4D) * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
#line 339 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRz.Apply((((-(8D) * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
#line 342 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicRz = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Rz));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ThreeQubitMeasurement_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ThreeQubitMeasurement_SimpleMeasurement : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ThreeQubitMeasurement_SimpleMeasurement(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ThreeQubitMeasurement_SimpleMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.ThreeQubitMeasurement_SimpleMeasurement";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian> MicrosoftQuantumArithmeticLittleEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64> MicrosoftQuantumArithmeticMeasureInteger
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicR1
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 350 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicR1.Apply((((-(2D) * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
#line 351 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicR1.Apply((((-(4D) * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
#line 352 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            WState_Arbitrary_Reference.Adjoint.Apply(qs);
#line 356 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumArithmeticMeasureInteger.Apply(new Microsoft.Quantum.Arithmetic.LittleEndian(qs)) == 0L) ? 0L : 1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticLittleEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.LittleEndian>>(typeof(Microsoft.Quantum.Arithmetic.LittleEndian));
            this.MicrosoftQuantumArithmeticMeasureInteger = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.LittleEndian, Int64>>(typeof(Microsoft.Quantum.Arithmetic.MeasureInteger));
            this.MicrosoftQuantumIntrinsicR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ThreeQubitMeasurement_SimpleMeasurement, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class IsQubitPlusOrZero_Reference : Operation<Qubit, Boolean>, ICallable
    {
        public IsQubitPlusOrZero_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlusOrZero_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlusOrZero_Reference";
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
#line 393 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((0.25D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)), q));
#line 394 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            return (MicrosoftQuantumIntrinsicM.Apply(q) == Result.Zero);
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
            return __m__.Run<IsQubitPlusOrZero_Reference, Qubit, Boolean>(q);
        }
    }

    public partial class IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference : Operation<Qubit, Int64>, ICallable
    {
        public IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference";
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

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 433 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var basis = MicrosoftQuantumMathRandomInt.Apply(2L);
#line 436 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            if ((basis == 0L))
            {
#line 439 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                var result = MicrosoftQuantumIntrinsicM.Apply(q);
#line 441 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                return ((result == Result.One) ? 1L : -(1L));
            }
            else
            {
#line 445 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
#line 446 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                var result = MicrosoftQuantumIntrinsicM.Apply(q);
#line 448 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                return ((result == Result.One) ? 0L : -(1L));
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitPlusZeroOrInconclusiveSimpleUSD_Reference, Qubit, Int64>(q);
        }
    }

    public partial class IsQubitNotInABC_Reference : Operation<Qubit, Int64>, ICallable
    {
        public IsQubitNotInABC_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "IsQubitNotInABC_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.IsQubitNotInABC_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
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

        protected ICallable<Double, Double> MicrosoftQuantumMathArcCos
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in__) =>
        {
            var q = __in__;
#line 480 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
            var alpha = MicrosoftQuantumMathArcCos.Apply(MicrosoftQuantumMathSqrt.Apply((2D / 3D)));
#line hidden
            {
#line 482 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                var a = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 483 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicZ.Apply(q);
#line 484 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a, q));
#line 485 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Controlled.Apply((new QArray<Qubit>(q), a));
#line 486 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicS.Apply(a);
#line 487 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 489 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumIntrinsicRy)).Apply((new QArray<Qubit>(a), ((-(2D) * alpha), q)));
#line 490 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a, q));
#line 491 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Controlled.Apply((new QArray<Qubit>(q), a));
#line 492 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a, q));
#line 495 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    var res0 = MicrosoftQuantumMeasurementMResetZ.Apply(a);
#line 496 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    var res1 = MicrosoftQuantumIntrinsicM.Apply(q);
#line 499 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                    if (((res0 == Result.Zero) && (res1 == Result.Zero)))
                    {
#line 500 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                        return 0L;
                    }
                    else if (((res0 == Result.One) && (res1 == Result.Zero)))
                    {
#line 503 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                        return 1L;
                    }
                    else if (((res0 == Result.Zero) && (res1 == Result.One)))
                    {
#line 506 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                        return 2L;
                    }
                    else
                    {
#line 510 "G:\\量子实习\\quantumKatas-VS\\Measurements\\ReferenceImplementation.qs"
                        return 3L;
                    }
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
                    Release.Apply(a);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.MicrosoftQuantumMathArcCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcCos));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<IsQubitNotInABC_Reference, Qubit, Int64>(q);
        }
    }
}