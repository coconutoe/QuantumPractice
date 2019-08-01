#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_Zero\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_Zero\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_One\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_One\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_Kth_Qubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"k\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_Kth_Qubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_OddNumberOfOnes\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_OddNumberOfOnes\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":86,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_ProductFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":107,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_ProductFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":107,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_ProductWithNegationFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_ProductWithNegationFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_HammingWithPrefix\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":159,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"prefix\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":67}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_HammingWithPrefix\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":159,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_MajorityFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":181,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Oracle_MajorityFunction\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":181,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_StatePrep\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":204,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"query\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"answer\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_StatePrep\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":204,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_StatePrep\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":204,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.DeutschJozsaAlgorithm.BV_StatePrep\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":228,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":228,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"BV_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":259,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"DJ_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":296,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"DJ_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":296,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"DJ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":331,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"DJ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":331,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Noname_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Uf\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"Noname_Algorithm\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tasks.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.DeutschJozsaAlgorithm
{
    public partial class Oracle_Zero : Operation<(IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Oracle_Zero(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Zero";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_Zero";
        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_Zero, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_One : Operation<(IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Oracle_One(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_One";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_One";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 62 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Apply(y);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_One, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_Kth_Qubit : Operation<(IQArray<Qubit>,Qubit,Int64), QVoid>, ICallable
    {
        public Oracle_Kth_Qubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_Kth_Qubit";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_Kth_Qubit";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,k) = __in__;
#line 75 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((0L <= k) && (k < x.Length)), true, "k should be between 0 and N-1, inclusive"));
#line 78 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[k], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, Int64 k)
        {
            return __m__.Run<Oracle_Kth_Qubit, (IQArray<Qubit>,Qubit,Int64), QVoid>((x, y, k));
        }
    }

    public partial class Oracle_OddNumberOfOnes : Operation<(IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Oracle_OddNumberOfOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_OddNumberOfOnes";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_OddNumberOfOnes";
        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 89 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var N = x.Length;
#line 91 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 92 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_OddNumberOfOnes, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class Oracle_ProductFunction : Operation<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>, ICallable
    {
        public Oracle_ProductFunction(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ProductFunction";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_ProductFunction";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,r) = __in__;
#line 111 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line 113 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var N = x.Length;
#line 115 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 116 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                if ((r[i] != 0L))
                {
#line 117 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> r)
        {
            return __m__.Run<Oracle_ProductFunction, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, r));
        }
    }

    public partial class Oracle_ProductWithNegationFunction : Operation<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>, ICallable
    {
        public Oracle_ProductWithNegationFunction(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_ProductWithNegationFunction";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_ProductWithNegationFunction";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,r) = __in__;
#line 134 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((x.Length, r.Length, "Arrays should have the same length"));
#line 136 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var N = x.Length;
#line 138 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 139 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                if ((r[i] != 0L))
                {
#line 140 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
                }
                else
                {
#line 142 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
#line 143 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y));
#line 144 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicX.Apply(x[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> r)
        {
            return __m__.Run<Oracle_ProductWithNegationFunction, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, r));
        }
    }

    public partial class Oracle_HammingWithPrefix : Operation<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>, ICallable
    {
        public Oracle_HammingWithPrefix(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,IQArray<Int64>)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_HammingWithPrefix";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_HammingWithPrefix";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Body => (__in__) =>
        {
            var (x,y,prefix) = __in__;
#line 163 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var P = prefix.Length;
#line 164 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((((1L <= P) && (P <= x.Length)), true, "P should be between 1 and N, inclusive"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,IQArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y, IQArray<Int64> prefix)
        {
            return __m__.Run<Oracle_HammingWithPrefix, (IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>((x, y, prefix));
        }
    }

    public partial class Oracle_MajorityFunction : Operation<(IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Oracle_MajorityFunction(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Oracle_MajorityFunction";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Oracle_MajorityFunction";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 185 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((3L == x.Length), true, "x should have exactly 3 qubits"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Oracle_MajorityFunction, (IQArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public partial class BV_StatePrep : Adjointable<(IQArray<Qubit>,Qubit)>, ICallable
    {
        public BV_StatePrep(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "BV_StatePrep";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.BV_StatePrep";
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit), QVoid> Body => (__in__) =>
        {
            var (query,answer) = __in__;
#line 207 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            foreach (var qs in query)
#line hidden
            {
#line 208 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                MicrosoftQuantumIntrinsicH.Apply(qs);
            }

#line 210 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Apply(answer);
#line 211 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(answer);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (query,answer) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(answer);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(answer);
#line hidden
            foreach (var qs in query?.Slice(new Range((query.Length - 1L), -1L, 0L)))
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
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> query, Qubit answer)
        {
            return __m__.Run<BV_StatePrep, (IQArray<Qubit>,Qubit), QVoid>((query, answer));
        }
    }

    public partial class BV_Algorithm : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public BV_Algorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "BV_Algorithm";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.BV_Algorithm";
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 233 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var r = QArray<Int64>.Create(N);
#line hidden
            {
#line 235 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 236 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    BV_StatePrep.Apply((x, y));
#line 238 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    Uf.Apply((x, y));
#line 239 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var qs in x)
#line hidden
                    {
#line 240 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        MicrosoftQuantumIntrinsicH.Apply(qs);
                    }

#line 242 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 243 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(x[i]);
#line 244 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        r.Modify(i, ((res == Result.One) ? 1L : 0L));
                    }

#line 247 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 248 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(y);
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
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 251 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            return r;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.BV_StatePrep = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<BV_Algorithm, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }

    public partial class BV_Test : Operation<QVoid, QVoid>, ICallable
    {
        public BV_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BV_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.BV_Test";
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
            return __m__.Run<BV_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class DJ_Algorithm : Operation<(Int64,ICallable), Boolean>, ICallable
    {
        public DJ_Algorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "DJ_Algorithm";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.DJ_Algorithm";
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Boolean> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 301 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var isConstantFunction = true;
#line hidden
            {
#line 308 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 309 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    BV_StatePrep.Apply((x, y));
#line 310 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    Uf.Apply((x, y));
#line 311 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var qs in x)
#line hidden
                    {
#line 312 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        MicrosoftQuantumIntrinsicH.Apply(qs);
                    }

#line 314 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var qs in x)
#line hidden
                    {
#line 315 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(qs);
#line 316 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        if ((res == Result.One))
                        {
#line 317 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                            isConstantFunction = false;
                        }
                    }

#line 321 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 322 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(y);
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
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 325 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            return isConstantFunction;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.BV_StatePrep = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<DJ_Algorithm, (Int64,ICallable), Boolean>((N, Uf));
        }
    }

    public partial class DJ_Test : Operation<QVoid, QVoid>, ICallable
    {
        public DJ_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DJ_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.DJ_Test";
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
            return __m__.Run<DJ_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Noname_Algorithm : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public Noname_Algorithm(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Noname_Algorithm";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.Noname_Algorithm";
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> Body => (__in__) =>
        {
            var (N,Uf) = __in__;
#line 365 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            var r = QArray<Int64>.Create(N);
#line hidden
            {
#line 367 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                var (x,y) = (Allocate.Apply(N), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 368 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    BV_StatePrep.Apply((x, y));
#line 370 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    Uf.Apply((x, y));
#line 371 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var qs in x)
#line hidden
                    {
#line 372 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        MicrosoftQuantumIntrinsicH.Apply(qs);
                    }

#line 374 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    foreach (var i in new Range(0L, (N - 1L)))
#line hidden
                    {
#line 375 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        var res = MicrosoftQuantumIntrinsicM.Apply(x[i]);
#line 376 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                        r.Modify(i, ((res == Result.One) ? 1L : 0L));
                    }

#line 379 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(x);
#line 380 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(y);
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
                    Release.Apply(x);
#line hidden
                    Release.Apply(y);
                }
            }

#line 382 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tasks.qs"
            return r;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.BV_StatePrep = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Noname_Algorithm, (Int64,ICallable), IQArray<Int64>>((N, Uf));
        }
    }
}