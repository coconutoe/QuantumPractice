#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"ApplyOracle\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"ApplyOracle\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"ApplyOracleA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.DeutschJozsaAlgorithm.ApplyOracleA\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertTwoOraclesAreEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"nQubits\"]},\"Type\":{\"Case\":\"Range\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Range\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertTwoOraclesAreEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T11_Oracle_Zero_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T11_Oracle_Zero_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T12_Oracle_One_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T12_Oracle_One_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T13_Oracle_Kth_Qubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T13_Oracle_Kth_Qubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T14_Oracle_OddNumberOfOnes_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T14_Oracle_OddNumberOfOnes_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntAreEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":80,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertTwoOraclesWithIntAreEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":80,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T15_Oracle_ProductFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T15_Oracle_ProductFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T16_Oracle_ProductWithNegationFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":54}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T16_Oracle_ProductWithNegationFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":54}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T17_Oracle_HammingWithPrefix_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T17_Oracle_HammingWithPrefix_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T18_Oracle_MajorityFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T18_Oracle_MajorityFunction_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T21_BV_StatePrep_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T21_BV_StatePrep_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AllEqualityFactI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":179,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"actual\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expected\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"String\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"String\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AllEqualityFactI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":179,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"IntArrFromPositiveInt\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":195,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"IntArrFromPositiveInt\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":195,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertBVAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":211,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertBVAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":211,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T22_BV_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T22_BV_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertDJAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expected\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"msg\"]},\"Type\":{\"Case\":\"String\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":101}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Bool\"},{\"Case\":\"String\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertDJAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T31_DJ_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":246,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T31_DJ_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":246,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertNonameAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"r\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertNonameAlgorithmWorks\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertNonameAlgorithmWorksOnInt\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":289,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"AssertNonameAlgorithmWorksOnInt\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":289,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T41_Noname_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":295,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.DeutschJozsaAlgorithm\",\"Name\":\"T41_Noname_Algorithm_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/DeutschJozsaAlgorithm/Tests.qs\",\"Position\":{\"Item1\":295,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.DeutschJozsaAlgorithm
{
    public partial class ApplyOracle : Operation<(IQArray<Qubit>,ICallable), QVoid>, ICallable
    {
        public ApplyOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,ICallable)>, IApplyData
        {
            public In((IQArray<Qubit>,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyOracle";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.ApplyOracle";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,ICallable), QVoid> Body => (__in__) =>
        {
            var (qs,oracle) = __in__;
#line 20 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var N = qs.Length;
#line 21 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            oracle.Apply((qs?.Slice(new Range(0L, (N - 2L))), qs[(N - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, ICallable oracle)
        {
            return __m__.Run<ApplyOracle, (IQArray<Qubit>,ICallable), QVoid>((qs, oracle));
        }
    }

    public partial class ApplyOracleA : Adjointable<(IQArray<Qubit>,IAdjointable)>, ICallable
    {
        public ApplyOracleA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IAdjointable)>, IApplyData
        {
            public In((IQArray<Qubit>,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ApplyOracleA";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.ApplyOracleA";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (qs,oracle) = __in__;
#line 28 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var N = qs.Length;
#line 29 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            oracle.Apply((qs?.Slice(new Range(0L, (N - 2L))), qs[(N - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IAdjointable), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,oracle) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            oracle.Adjoint.Apply((qs?.Slice(new Range(0L, (N - 2L))), qs[(N - 1L)]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IAdjointable oracle)
        {
            return __m__.Run<ApplyOracleA, (IQArray<Qubit>,IAdjointable), QVoid>((qs, oracle));
        }
    }

    public partial class AssertTwoOraclesAreEqual : Operation<(Range,ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Range,ICallable,IAdjointable)>, IApplyData
        {
            public In((Range,ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesAreEqual";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertTwoOraclesAreEqual";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,ICallable), QVoid> ApplyOracle
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> ApplyOracleA
        {
            get;
            set;
        }

        public override Func<(Range,ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (nQubits,oracle1,oracle2) = __in__;
#line 37 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var sol = ApplyOracle.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,ICallable)>((__arg1__) => (__arg1__, oracle1)));
#line 38 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var refSol = ApplyOracleA.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg2__) => (__arg2__, oracle2)));
#line 40 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in nQubits)
#line hidden
            {
#line 41 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((i + 1L), sol, refSol));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ApplyOracle = this.Factory.Get<ICallable<(IQArray<Qubit>,ICallable), QVoid>>(typeof(ApplyOracle));
            this.ApplyOracleA = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(ApplyOracleA));
        }

        public override IApplyData __dataIn((Range,ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Range nQubits, ICallable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesAreEqual, (Range,ICallable,IAdjointable), QVoid>((nQubits, oracle1, oracle2));
        }
    }

    public partial class T11_Oracle_Zero_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_Oracle_Zero_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_Oracle_Zero_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T11_Oracle_Zero_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Oracle_Zero
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_Zero_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 48 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 10L), Oracle_Zero, Oracle_Zero_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_Zero = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(Oracle_Zero));
            this.Oracle_Zero_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_Zero_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_Oracle_Zero_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_Oracle_One_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_Oracle_One_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_Oracle_One_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T12_Oracle_One_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Oracle_One
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_One_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 54 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 10L), Oracle_One, Oracle_One_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_One = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(Oracle_One));
            this.Oracle_One_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_One_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_Oracle_One_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_Oracle_Kth_Qubit_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_Oracle_Kth_Qubit_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_Oracle_Kth_Qubit_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T13_Oracle_Kth_Qubit_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit,Int64), QVoid> Oracle_Kth_Qubit
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,Int64)> Oracle_Kth_Qubit_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 60 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var maxQ = 6L;
#line 63 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var k in new Range(0L, (maxQ - 1L)))
#line hidden
            {
#line 65 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range((k + 1L), maxQ), Oracle_Kth_Qubit.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, k))), Oracle_Kth_Qubit_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, k)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_Kth_Qubit = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit,Int64), QVoid>>(typeof(Oracle_Kth_Qubit));
            this.Oracle_Kth_Qubit_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,Int64)>>(typeof(Oracle_Kth_Qubit_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_Oracle_Kth_Qubit_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_Oracle_OddNumberOfOnes_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_Oracle_OddNumberOfOnes_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_Oracle_OddNumberOfOnes_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T14_Oracle_OddNumberOfOnes_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,Int64)> Oracle_Kth_Qubit_Reference
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Oracle_OddNumberOfOnes
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 74 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 1L), Oracle_OddNumberOfOnes, Oracle_Kth_Qubit_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, 0L)))));
#line 76 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 10L), Oracle_OddNumberOfOnes, Oracle_OddNumberOfOnes_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_Kth_Qubit_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,Int64)>>(typeof(Oracle_Kth_Qubit_Reference));
            this.Oracle_OddNumberOfOnes = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(Oracle_OddNumberOfOnes));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_Oracle_OddNumberOfOnes_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertTwoOraclesWithIntAreEqual : Operation<(IQArray<Int64>,ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertTwoOraclesWithIntAreEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,ICallable,IAdjointable)>, IApplyData
        {
            public In((IQArray<Int64>,ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertTwoOraclesWithIntAreEqual";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertTwoOraclesWithIntAreEqual";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (r,oracle1,oracle2) = __in__;
#line 84 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(r.Length, r.Length), oracle1.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, r))), oracle2.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, r)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
        }

        public override IApplyData __dataIn((IQArray<Int64>,ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> r, ICallable oracle1, IAdjointable oracle2)
        {
            return __m__.Run<AssertTwoOraclesWithIntAreEqual, (IQArray<Int64>,ICallable,IAdjointable), QVoid>((r, oracle1, oracle2));
        }
    }

    public partial class T15_Oracle_ProductFunction_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T15_Oracle_ProductFunction_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T15_Oracle_ProductFunction_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T15_Oracle_ProductFunction_Test";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,ICallable,IAdjointable), QVoid> AssertTwoOraclesWithIntAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,Int64)> Oracle_Kth_Qubit_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Oracle_ProductFunction
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductFunction_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_Zero_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 91 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var r = new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L);
#line 92 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var L = r.Length;
#line 94 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(2L, L))
#line hidden
            {
#line 95 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range(i, i), Oracle_ProductFunction.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, r?.Slice(new Range(0L, (i - 1L)))))), Oracle_OddNumberOfOnes_Reference));
            }

#line 99 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(0L, (L - 1L)))
#line hidden
            {
#line 100 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                r.Modify(i, 0L);
            }

#line 103 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(2L, L))
#line hidden
            {
#line 104 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range(i, i), Oracle_ProductFunction.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, r?.Slice(new Range(0L, (i - 1L)))))), Oracle_Zero_Reference));
            }

#line 108 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(0L, (L - 1L)))
#line hidden
            {
#line 109 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range(L, L), Oracle_ProductFunction.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg3__) => (__arg3__.Item1, __arg3__.Item2, new QArray<Int64>(r).Modify(i, 1L)))), Oracle_Kth_Qubit_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg4__) => (__arg4__.Item1, __arg4__.Item2, i)))));
            }

#line 112 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L);
#line 113 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductFunction, Oracle_ProductFunction_Reference));
#line 115 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 116 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductFunction, Oracle_ProductFunction_Reference));
#line 118 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(0L, 0L, 1L, 1L, 1L);
#line 119 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductFunction, Oracle_ProductFunction_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.AssertTwoOraclesWithIntAreEqual = this.Factory.Get<ICallable<(IQArray<Int64>,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithIntAreEqual));
            this.Oracle_Kth_Qubit_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,Int64)>>(typeof(Oracle_Kth_Qubit_Reference));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
            this.Oracle_ProductFunction = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>>(typeof(Oracle_ProductFunction));
            this.Oracle_ProductFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductFunction_Reference));
            this.Oracle_Zero_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_Zero_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T15_Oracle_ProductFunction_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T16_Oracle_ProductWithNegationFunction_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T16_Oracle_ProductWithNegationFunction_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T16_Oracle_ProductWithNegationFunction_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T16_Oracle_ProductWithNegationFunction_Test";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Int64>,ICallable,IAdjointable), QVoid> AssertTwoOraclesWithIntAreEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Oracle_ProductWithNegationFunction
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductWithNegationFunction_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 126 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var r = new QArray<Int64>(1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L, 1L);
#line 127 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var L = r.Length;
#line 129 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(2L, L))
#line hidden
            {
#line 130 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                AssertTwoOraclesAreEqual.Apply((new Range(i, i), Oracle_ProductWithNegationFunction.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, r?.Slice(new Range(0L, (i - 1L)))))), Oracle_OddNumberOfOnes_Reference));
            }

#line 133 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L);
#line 134 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductWithNegationFunction, Oracle_ProductWithNegationFunction_Reference));
#line 136 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(1L, 0L, 0L, 1L);
#line 137 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductWithNegationFunction, Oracle_ProductWithNegationFunction_Reference));
#line 139 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            r = new QArray<Int64>(0L, 0L, 1L, 1L, 1L);
#line 140 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesWithIntAreEqual.Apply((r?.Copy(), Oracle_ProductWithNegationFunction, Oracle_ProductWithNegationFunction_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.AssertTwoOraclesWithIntAreEqual = this.Factory.Get<ICallable<(IQArray<Int64>,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesWithIntAreEqual));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
            this.Oracle_ProductWithNegationFunction = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>>(typeof(Oracle_ProductWithNegationFunction));
            this.Oracle_ProductWithNegationFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductWithNegationFunction_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T16_Oracle_ProductWithNegationFunction_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T17_Oracle_HammingWithPrefix_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T17_Oracle_HammingWithPrefix_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T17_Oracle_HammingWithPrefix_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T17_Oracle_HammingWithPrefix_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid> Oracle_HammingWithPrefix
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_HammingWithPrefix_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 145 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var prefix = new QArray<Int64>(1L);
#line 146 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(1L, 10L), Oracle_HammingWithPrefix.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, prefix?.Copy()))), Oracle_HammingWithPrefix_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, prefix?.Copy())))));
#line 148 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            prefix = new QArray<Int64>(1L, 0L);
#line 149 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(2L, 10L), Oracle_HammingWithPrefix.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg3__) => (__arg3__.Item1, __arg3__.Item2, prefix?.Copy()))), Oracle_HammingWithPrefix_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg4__) => (__arg4__.Item1, __arg4__.Item2, prefix?.Copy())))));
#line 151 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            prefix = new QArray<Int64>(0L, 0L, 0L);
#line 152 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(3L, 10L), Oracle_HammingWithPrefix.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg5__) => (__arg5__.Item1, __arg5__.Item2, prefix?.Copy()))), Oracle_HammingWithPrefix_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg6__) => (__arg6__.Item1, __arg6__.Item2, prefix?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_HammingWithPrefix = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit,IQArray<Int64>), QVoid>>(typeof(Oracle_HammingWithPrefix));
            this.Oracle_HammingWithPrefix_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_HammingWithPrefix_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T17_Oracle_HammingWithPrefix_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T18_Oracle_MajorityFunction_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T18_Oracle_MajorityFunction_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T18_Oracle_MajorityFunction_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T18_Oracle_MajorityFunction_Test";
        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Qubit), QVoid> Oracle_MajorityFunction
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_MajorityFunction_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 157 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(3L, 3L), Oracle_MajorityFunction, Oracle_MajorityFunction_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Oracle_MajorityFunction = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit), QVoid>>(typeof(Oracle_MajorityFunction));
            this.Oracle_MajorityFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_MajorityFunction_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T18_Oracle_MajorityFunction_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T21_BV_StatePrep_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_BV_StatePrep_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_BV_StatePrep_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T21_BV_StatePrep_Test";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumDiagnosticsAssertAllZero
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

        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> BV_StatePrep_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 164 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var N in new Range(1L, 10L))
#line hidden
            {
#line hidden
                {
#line 166 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    var qs = Allocate.Apply((N + 1L));
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 168 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                        BV_StatePrep.Apply((qs?.Slice(new Range(0L, (N - 1L))), qs[N]));
#line 171 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                        BV_StatePrep_Reference.Adjoint.Apply((qs?.Slice(new Range(0L, (N - 1L))), qs[N]));
#line 174 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                        MicrosoftQuantumDiagnosticsAssertAllZero.Apply(qs);
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
                        Release.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.BV_StatePrep = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep));
            this.BV_StatePrep_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(BV_StatePrep_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_BV_StatePrep_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AllEqualityFactI : Function<(IQArray<Int64>,IQArray<Int64>,String), QVoid>, ICallable
    {
        public AllEqualityFactI(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,IQArray<Int64>,String)>, IApplyData
        {
            public In((IQArray<Int64>,IQArray<Int64>,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AllEqualityFactI";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AllEqualityFactI";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,IQArray<Int64>,String), QVoid> Body => (__in__) =>
        {
            var (actual,expected,message) = __in__;
#line 182 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var n = actual.Length;
#line 183 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            if ((n != expected.Length))
            {
#line 184 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                throw new ExecutionFailException(message);
            }

#line 187 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var idx in new Range(0L, (n - 1L)))
#line hidden
            {
#line 188 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                if ((actual[idx] != expected[idx]))
                {
#line 189 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    throw new ExecutionFailException(message);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn((IQArray<Int64>,IQArray<Int64>,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> actual, IQArray<Int64> expected, String message)
        {
            return __m__.Run<AllEqualityFactI, (IQArray<Int64>,IQArray<Int64>,String), QVoid>((actual, expected, message));
        }
    }

    public partial class IntArrFromPositiveInt : Function<(Int64,Int64), IQArray<Int64>>, ICallable
    {
        public IntArrFromPositiveInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "IntArrFromPositiveInt";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.IntArrFromPositiveInt";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), IQArray<Int64>> Body => (__in__) =>
        {
            var (n,bits) = __in__;
#line 198 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var rbool = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((n, bits));
#line 199 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var r = QArray<Int64>.Create(bits);
#line 201 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var i in new Range(0L, (bits - 1L)))
#line hidden
            {
#line 202 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                if (rbool[i])
                {
#line 203 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    r.Modify(i, 1L);
                }
            }

#line 207 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            return r;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 n, Int64 bits)
        {
            return __m__.Run<IntArrFromPositiveInt, (Int64,Int64), IQArray<Int64>>((n, bits));
        }
    }

    public partial class AssertBVAlgorithmWorks : Operation<IQArray<Int64>, QVoid>, ICallable
    {
        public AssertBVAlgorithmWorks(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AssertBVAlgorithmWorks";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertBVAlgorithmWorks";
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

        protected ICallable<(IQArray<Int64>,IQArray<Int64>,String), QVoid> AllEqualityFactI
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), IQArray<Int64>> BV_Algorithm
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductFunction_Reference
        {
            get;
            set;
        }

        protected ICallable QuantumKataUtilsGetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<IQArray<Int64>, QVoid> Body => (__in__) =>
        {
            var r = __in__;
#line 213 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var oracle = Oracle_ProductFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, r)));
#line 214 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AllEqualityFactI.Apply((BV_Algorithm.Apply((r.Length, oracle)), r, "Bernstein-Vazirani algorithm failed"));
#line 216 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var nu = QuantumKataUtilsGetOracleCallsCount.Apply<Int64>(oracle);
#line 217 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((nu <= 1L), true, String.Format("You are allowed to call the oracle at most once, and you called it {0} times", nu)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.AllEqualityFactI = this.Factory.Get<ICallable<(IQArray<Int64>,IQArray<Int64>,String), QVoid>>(typeof(AllEqualityFactI));
            this.BV_Algorithm = this.Factory.Get<ICallable<(Int64,ICallable), IQArray<Int64>>>(typeof(BV_Algorithm));
            this.Oracle_ProductFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductFunction_Reference));
            this.QuantumKataUtilsGetOracleCallsCount = this.Factory.Get<ICallable>(typeof(Quantum.Kata.Utils.GetOracleCallsCount<>));
        }

        public override IApplyData __dataIn(IQArray<Int64> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> r)
        {
            return __m__.Run<AssertBVAlgorithmWorks, IQArray<Int64>, QVoid>(r);
        }
    }

    public partial class T22_BV_Algorithm_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_BV_Algorithm_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_BV_Algorithm_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T22_BV_Algorithm_Test";
        protected ICallable<IQArray<Int64>, QVoid> AssertBVAlgorithmWorks
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IQArray<Int64>> IntArrFromPositiveInt
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> QuantumKataUtilsResetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 222 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            QuantumKataUtilsResetOracleCallsCount.Apply(QVoid.Instance);
#line 226 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var bits in new Range(1L, 4L))
#line hidden
            {
#line 227 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                foreach (var n in new Range(0L, (2L.Pow(bits) - 1L)))
#line hidden
                {
#line 228 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    var r = (IQArray<Int64>)IntArrFromPositiveInt.Apply((n, bits));
#line 229 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    AssertBVAlgorithmWorks.Apply(r);
                }
            }

#line 233 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertBVAlgorithmWorks.Apply(new QArray<Int64>(1L, 1L, 1L, 0L, 0L));
#line 234 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertBVAlgorithmWorks.Apply(new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertBVAlgorithmWorks = this.Factory.Get<ICallable<IQArray<Int64>, QVoid>>(typeof(AssertBVAlgorithmWorks));
            this.IntArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Int64>>>(typeof(IntArrFromPositiveInt));
            this.QuantumKataUtilsResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(Quantum.Kata.Utils.ResetOracleCallsCount));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_BV_Algorithm_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertDJAlgorithmWorks : Operation<(Int64,ICallable,Boolean,String), QVoid>, ICallable
    {
        public AssertDJAlgorithmWorks(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,Boolean,String)>, IApplyData
        {
            public In((Int64,ICallable,Boolean,String) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "AssertDJAlgorithmWorks";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertDJAlgorithmWorks";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Boolean> DJ_Algorithm
        {
            get;
            set;
        }

        protected ICallable QuantumKataUtilsGetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable,Boolean,String), QVoid> Body => (__in__) =>
        {
            var (N,oracle,expected,msg) = __in__;
#line 240 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((DJ_Algorithm.Apply((N, oracle)), expected, msg));
#line 242 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var nu = QuantumKataUtilsGetOracleCallsCount.Apply<Int64>(oracle);
#line 243 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((nu <= 1L), true, String.Format("You are allowed to call the oracle at most once, and you called it {0} times", nu)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.DJ_Algorithm = this.Factory.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(DJ_Algorithm));
            this.QuantumKataUtilsGetOracleCallsCount = this.Factory.Get<ICallable>(typeof(Quantum.Kata.Utils.GetOracleCallsCount<>));
        }

        public override IApplyData __dataIn((Int64,ICallable,Boolean,String) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable oracle, Boolean expected, String msg)
        {
            return __m__.Run<AssertDJAlgorithmWorks, (Int64,ICallable,Boolean,String), QVoid>((N, oracle, expected, msg));
        }
    }

    public partial class T31_DJ_Algorithm_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T31_DJ_Algorithm_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T31_DJ_Algorithm_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T31_DJ_Algorithm_Test";
        protected ICallable<(Int64,ICallable,Boolean,String), QVoid> AssertDJAlgorithmWorks
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_HammingWithPrefix_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,Int64)> Oracle_Kth_Qubit_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_MajorityFunction_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_OddNumberOfOnes_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_One_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductFunction_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductWithNegationFunction_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_Zero_Reference
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> QuantumKataUtilsResetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 249 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            QuantumKataUtilsResetOracleCallsCount.Apply(QVoid.Instance);
#line 253 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_Zero_Reference, true, "f(x) = 0 not identified as constant"));
#line 255 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_One_Reference, true, "f(x) = 1 not identified as constant"));
#line 257 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_Kth_Qubit_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,Int64)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, 1L))), false, "f(x) = x_k not identified as balanced"));
#line 259 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_OddNumberOfOnes_Reference, false, "f(x) = sum of x_i not identified as balanced"));
#line 261 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_ProductFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, new QArray<Int64>(1L, 0L, 1L, 1L)))), false, "f(x) = sum of r_i x_i not identified as balanced"));
#line 263 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_ProductWithNegationFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg3__) => (__arg3__.Item1, __arg3__.Item2, new QArray<Int64>(1L, 0L, 1L, 1L)))), false, "f(x) = sum of r_i x_i + (1 - r_i)(1 - x_i) not identified as balanced"));
#line 265 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((4L, Oracle_HammingWithPrefix_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg4__) => (__arg4__.Item1, __arg4__.Item2, new QArray<Int64>(0L, 1L)))), false, "f(x) = sum of x_i + 1 if prefix equals given not identified as balanced"));
#line 267 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertDJAlgorithmWorks.Apply((3L, Oracle_MajorityFunction_Reference, false, "f(x) = majority function not identified as balanced"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertDJAlgorithmWorks = this.Factory.Get<ICallable<(Int64,ICallable,Boolean,String), QVoid>>(typeof(AssertDJAlgorithmWorks));
            this.Oracle_HammingWithPrefix_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_HammingWithPrefix_Reference));
            this.Oracle_Kth_Qubit_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,Int64)>>(typeof(Oracle_Kth_Qubit_Reference));
            this.Oracle_MajorityFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_MajorityFunction_Reference));
            this.Oracle_OddNumberOfOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_OddNumberOfOnes_Reference));
            this.Oracle_One_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_One_Reference));
            this.Oracle_ProductFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductFunction_Reference));
            this.Oracle_ProductWithNegationFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductWithNegationFunction_Reference));
            this.Oracle_Zero_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_Zero_Reference));
            this.QuantumKataUtilsResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(Quantum.Kata.Utils.ResetOracleCallsCount));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T31_DJ_Algorithm_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertNonameAlgorithmWorks : Operation<IQArray<Int64>, QVoid>, ICallable
    {
        public AssertNonameAlgorithmWorks(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AssertNonameAlgorithmWorks";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertNonameAlgorithmWorks";
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

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected ICallable<(Range,ICallable,IAdjointable), QVoid> AssertTwoOraclesAreEqual
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), IQArray<Int64>> Noname_Algorithm
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)> Oracle_ProductWithNegationFunction_Reference
        {
            get;
            set;
        }

        protected ICallable QuantumKataUtilsGetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<IQArray<Int64>, QVoid> Body => (__in__) =>
        {
            var r = __in__;
#line 275 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var givenOracle = Oracle_ProductWithNegationFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, r)));
#line 276 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var res = (IQArray<Int64>)Noname_Algorithm.Apply((r.Length, givenOracle));
#line 279 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var nu = QuantumKataUtilsGetOracleCallsCount.Apply<Int64>(givenOracle);
#line 280 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((nu <= 1L), true, String.Format("You are allowed to call the oracle at most once, and you called it {0} times", nu)));
#line 284 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((res.Length, r.Length, "Returned bit vector must have the same length as the oracle input."));
#line 285 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var resOracle = Oracle_ProductWithNegationFunction_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Int64>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, res)));
#line 286 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertTwoOraclesAreEqual.Apply((new Range(r.Length, r.Length), givenOracle, resOracle));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.AssertTwoOraclesAreEqual = this.Factory.Get<ICallable<(Range,ICallable,IAdjointable), QVoid>>(typeof(AssertTwoOraclesAreEqual));
            this.Noname_Algorithm = this.Factory.Get<ICallable<(Int64,ICallable), IQArray<Int64>>>(typeof(Noname_Algorithm));
            this.Oracle_ProductWithNegationFunction_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Int64>)>>(typeof(Oracle_ProductWithNegationFunction_Reference));
            this.QuantumKataUtilsGetOracleCallsCount = this.Factory.Get<ICallable>(typeof(Quantum.Kata.Utils.GetOracleCallsCount<>));
        }

        public override IApplyData __dataIn(IQArray<Int64> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> r)
        {
            return __m__.Run<AssertNonameAlgorithmWorks, IQArray<Int64>, QVoid>(r);
        }
    }

    public partial class AssertNonameAlgorithmWorksOnInt : Operation<(Int64,Int64), QVoid>, ICallable
    {
        public AssertNonameAlgorithmWorksOnInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AssertNonameAlgorithmWorksOnInt";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.AssertNonameAlgorithmWorksOnInt";
        protected ICallable<IQArray<Int64>, QVoid> AssertNonameAlgorithmWorks
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IQArray<Int64>> IntArrFromPositiveInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QVoid> Body => (__in__) =>
        {
            var (n,bits) = __in__;
#line 291 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            var r = (IQArray<Int64>)IntArrFromPositiveInt.Apply((n, bits));
#line 292 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertNonameAlgorithmWorks.Apply(r);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertNonameAlgorithmWorks = this.Factory.Get<ICallable<IQArray<Int64>, QVoid>>(typeof(AssertNonameAlgorithmWorks));
            this.IntArrFromPositiveInt = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Int64>>>(typeof(IntArrFromPositiveInt));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 n, Int64 bits)
        {
            return __m__.Run<AssertNonameAlgorithmWorksOnInt, (Int64,Int64), QVoid>((n, bits));
        }
    }

    public partial class T41_Noname_Algorithm_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T41_Noname_Algorithm_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T41_Noname_Algorithm_Test";
        String ICallable.FullName => "Quantum.Kata.DeutschJozsaAlgorithm.T41_Noname_Algorithm_Test";
        protected ICallable<IQArray<Int64>, QVoid> AssertNonameAlgorithmWorks
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), QVoid> AssertNonameAlgorithmWorksOnInt
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> QuantumKataUtilsResetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 298 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            QuantumKataUtilsResetOracleCallsCount.Apply(QVoid.Instance);
#line 302 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            foreach (var bits in new Range(1L, 4L))
#line hidden
            {
#line 304 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                foreach (var n in new Range(0L, (2L.Pow(bits) - 1L)))
#line hidden
                {
#line 305 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
                    AssertNonameAlgorithmWorksOnInt.Apply((n, bits));
                }
            }

#line 310 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertNonameAlgorithmWorks.Apply(new QArray<Int64>(1L, 1L, 1L, 0L, 0L));
#line 311 "G:\\量子实习\\quantumKatas-VS\\DeutschJozsaAlgorithm\\Tests.qs"
            AssertNonameAlgorithmWorks.Apply(new QArray<Int64>(1L, 0L, 1L, 0L, 1L, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertNonameAlgorithmWorks = this.Factory.Get<ICallable<IQArray<Int64>, QVoid>>(typeof(AssertNonameAlgorithmWorks));
            this.AssertNonameAlgorithmWorksOnInt = this.Factory.Get<ICallable<(Int64,Int64), QVoid>>(typeof(AssertNonameAlgorithmWorksOnInt));
            this.QuantumKataUtilsResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(Quantum.Kata.Utils.ResetOracleCallsCount));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T41_Noname_Algorithm_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}