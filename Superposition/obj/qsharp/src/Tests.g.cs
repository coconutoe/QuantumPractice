#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":34,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ArrayWrapperOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ArrayWrapperOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ArrayWrapperOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":38,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":91}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.ArrayWrapperOperationA\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T01_PlusState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T01_PlusState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T02_MinusState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T02_MinusState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T03_UnequalSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T03_UnequalSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T04_AllBasisVectors_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T04_AllBasisVectors_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T05_AllBasisVectorsWithPhases_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T05_AllBasisVectorsWithPhases_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":78,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":55}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T06_BellState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T06_BellState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T07_AllBellStates_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T07_AllBellStates_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T08_GHZ_State_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T08_GHZ_State_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T09_AllBasisVectorsSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T09_AllBasisVectorsSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":113,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T10_ThreeStates_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T10_ThreeStates_TwoQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T11_ZeroAndBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T11_ZeroAndBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T12_TwoBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T12_TwoBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T13_FourBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":177,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T13_FourBitstringSuperposition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":177,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T14_WState_PowerOfTwo_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T14_WState_PowerOfTwo_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":215,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T15_WState_Arbitrary_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":231,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"T15_WState_Arbitrary_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/Tests.qs\",\"Position\":{\"Item1\":231,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Superposition
{
    public partial class AssertEqualOnZeroState : Operation<(Int64,ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertEqualOnZeroState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,IAdjointable)>, IApplyData
        {
            public In((Int64,ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertEqualOnZeroState";
        String ICallable.FullName => "Quantum.Kata.Superposition.AssertEqualOnZeroState";
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

        public override Func<(Int64,ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (N,testImpl,refImpl) = __in__;
#line hidden
            {
#line 21 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                var qs = Allocate.Apply(N);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 23 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    testImpl.Apply(qs);
#line 26 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    refImpl.Adjoint.Apply(qs);
#line 29 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
        }

        public override IApplyData __dataIn((Int64,ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable testImpl, IAdjointable refImpl)
        {
            return __m__.Run<AssertEqualOnZeroState, (Int64,ICallable,IAdjointable), QVoid>((N, testImpl, refImpl));
        }
    }

    public partial class ArrayWrapperOperation : Operation<(ICallable,IQArray<Qubit>), QVoid>, ICallable
    {
        public ArrayWrapperOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IQArray<Qubit>)>, IApplyData
        {
            public In((ICallable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ArrayWrapperOperation";
        String ICallable.FullName => "Quantum.Kata.Superposition.ArrayWrapperOperation";
        public override Func<(ICallable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 36 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, IQArray<Qubit> qs)
        {
            return __m__.Run<ArrayWrapperOperation, (ICallable,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class ArrayWrapperOperationA : Adjointable<(IAdjointable,IQArray<Qubit>)>, ICallable
    {
        public ArrayWrapperOperationA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IQArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ArrayWrapperOperationA";
        String ICallable.FullName => "Quantum.Kata.Superposition.ArrayWrapperOperationA";
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 40 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, IQArray<Qubit> qs)
        {
            return __m__.Run<ArrayWrapperOperationA, (IAdjointable,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class T01_PlusState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T01_PlusState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T01_PlusState_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T01_PlusState_Test";
        protected ICallable<(ICallable,IQArray<Qubit>), QVoid> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> PlusState
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 45 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg1__) => (PlusState, __arg1__))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (PlusState_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ArrayWrapperOperation = this.Factory.Get<ICallable<(ICallable,IQArray<Qubit>), QVoid>>(typeof(ArrayWrapperOperation));
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.PlusState = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(PlusState));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T01_PlusState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T02_MinusState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T02_MinusState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T02_MinusState_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T02_MinusState_Test";
        protected ICallable<(ICallable,IQArray<Qubit>), QVoid> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> MinusState
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> MinusState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 51 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg1__) => (MinusState, __arg1__))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (MinusState_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ArrayWrapperOperation = this.Factory.Get<ICallable<(ICallable,IQArray<Qubit>), QVoid>>(typeof(ArrayWrapperOperation));
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.MinusState = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(MinusState));
            this.MinusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(MinusState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T02_MinusState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T03_UnequalSuperposition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T03_UnequalSuperposition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T03_UnequalSuperposition_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T03_UnequalSuperposition_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicY
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IQArray<Qubit>), QVoid> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> MinusState_Reference
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Double), QVoid> UnequalSuperposition
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Double)> UnequalSuperposition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 58 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg1__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg2__) => (__arg2__, 0D))), __arg1__))), MicrosoftQuantumCanonApplyToEachA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg3__) => (MicrosoftQuantumIntrinsicI, __arg3__)))));
#line 59 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg4__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg5__) => (__arg5__, (0.5D * MicrosoftQuantumMathPI.Apply(QVoid.Instance))))), __arg4__))), MicrosoftQuantumCanonApplyToEachA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg6__) => (MicrosoftQuantumIntrinsicX, __arg6__)))));
#line 60 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg7__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg8__) => (__arg8__, (0.5D * MicrosoftQuantumMathPI.Apply(QVoid.Instance))))), __arg7__))), MicrosoftQuantumCanonApplyToEachA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg9__) => (MicrosoftQuantumIntrinsicY, __arg9__)))));
#line 61 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg10__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg11__) => (__arg11__, (0.25D * MicrosoftQuantumMathPI.Apply(QVoid.Instance))))), __arg10__))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg12__) => (PlusState_Reference, __arg12__)))));
#line 62 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg13__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg14__) => (__arg14__, (0.75D * MicrosoftQuantumMathPI.Apply(QVoid.Instance))))), __arg13__))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg15__) => (MinusState_Reference, __arg15__)))));
#line 64 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var i in new Range(1L, 36L))
#line hidden
            {
#line 65 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 66 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((1L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg16__) => (UnequalSuperposition.Partial(new Func<Qubit, (Qubit,Double)>((__arg17__) => (__arg17__, alpha))), __arg16__))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg18__) => (UnequalSuperposition_Reference.Partial(new Func<Qubit, (Qubit,Double)>((__arg19__) => (__arg19__, alpha))), __arg18__)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Y));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.ArrayWrapperOperation = this.Factory.Get<ICallable<(ICallable,IQArray<Qubit>), QVoid>>(typeof(ArrayWrapperOperation));
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.MinusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(MinusState_Reference));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
            this.UnequalSuperposition = this.Factory.Get<ICallable<(Qubit,Double), QVoid>>(typeof(UnequalSuperposition));
            this.UnequalSuperposition_Reference = this.Factory.Get<IAdjointable<(Qubit,Double)>>(typeof(UnequalSuperposition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T03_UnequalSuperposition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T04_AllBasisVectors_TwoQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T04_AllBasisVectors_TwoQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T04_AllBasisVectors_TwoQubits_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T04_AllBasisVectors_TwoQubits_Test";
        protected ICallable<IQArray<Qubit>, QVoid> AllBasisVectors_TwoQubits
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> AllBasisVectors_TwoQubits_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 74 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, AllBasisVectors_TwoQubits, AllBasisVectors_TwoQubits_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AllBasisVectors_TwoQubits = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(AllBasisVectors_TwoQubits));
            this.AllBasisVectors_TwoQubits_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(AllBasisVectors_TwoQubits_Reference));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T04_AllBasisVectors_TwoQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T05_AllBasisVectorsWithPhases_TwoQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T05_AllBasisVectorsWithPhases_TwoQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T05_AllBasisVectorsWithPhases_TwoQubits_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T05_AllBasisVectorsWithPhases_TwoQubits_Test";
        protected ICallable<IQArray<Qubit>, QVoid> AllBasisVectorsWithPhases_TwoQubits
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> AllBasisVectorsWithPhases_TwoQubits_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 81 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, AllBasisVectorsWithPhases_TwoQubits, AllBasisVectorsWithPhases_TwoQubits_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AllBasisVectorsWithPhases_TwoQubits = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(AllBasisVectorsWithPhases_TwoQubits));
            this.AllBasisVectorsWithPhases_TwoQubits_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(AllBasisVectorsWithPhases_TwoQubits_Reference));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T05_AllBasisVectorsWithPhases_TwoQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T06_BellState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T06_BellState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T06_BellState_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T06_BellState_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> BellState
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> BellState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 87 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, BellState, BellState_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.BellState = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(BellState));
            this.BellState_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(BellState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T06_BellState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T07_AllBellStates_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T07_AllBellStates_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T07_AllBellStates_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T07_AllBellStates_Test";
        protected ICallable<(IQArray<Qubit>,Int64), QVoid> AllBellStates
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64)> AllBellStates_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 93 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var i in new Range(0L, 3L))
#line hidden
            {
#line 94 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((2L, AllBellStates.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,Int64)>((__arg1__) => (__arg1__, i))), AllBellStates_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,Int64)>((__arg2__) => (__arg2__, i)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AllBellStates = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(AllBellStates));
            this.AllBellStates_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64)>>(typeof(AllBellStates_Reference));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T07_AllBellStates_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T08_GHZ_State_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T08_GHZ_State_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T08_GHZ_State_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T08_GHZ_State_Test";
        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> BellState_Reference
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> GHZ_State
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> GHZ_State_Reference
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 102 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, GHZ_State, ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (PlusState_Reference, __arg1__)))));
#line 105 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, GHZ_State, BellState_Reference));
#line 107 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var n in new Range(3L, 9L))
#line hidden
            {
#line 108 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((n, GHZ_State, GHZ_State_Reference));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.BellState_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(BellState_Reference));
            this.GHZ_State = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(GHZ_State));
            this.GHZ_State_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(GHZ_State_Reference));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T08_GHZ_State_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T09_AllBasisVectorsSuperposition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T09_AllBasisVectorsSuperposition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T09_AllBasisVectorsSuperposition_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T09_AllBasisVectorsSuperposition_Test";
        protected ICallable<IQArray<Qubit>, QVoid> AllBasisVectorsSuperposition
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> AllBasisVectorsSuperposition_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 116 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, AllBasisVectorsSuperposition, ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (PlusState_Reference, __arg1__)))));
#line 118 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var n in new Range(2L, 9L))
#line hidden
            {
#line 119 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((n, AllBasisVectorsSuperposition, AllBasisVectorsSuperposition_Reference));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AllBasisVectorsSuperposition = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(AllBasisVectorsSuperposition));
            this.AllBasisVectorsSuperposition_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(AllBasisVectorsSuperposition_Reference));
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T09_AllBasisVectorsSuperposition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T10_ThreeStates_TwoQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T10_ThreeStates_TwoQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T10_ThreeStates_TwoQubits_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T10_ThreeStates_TwoQubits_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> ThreeStates_TwoQubits
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ThreeStates_TwoQubits_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 126 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, ThreeStates_TwoQubits, ThreeStates_TwoQubits_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.ThreeStates_TwoQubits = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ThreeStates_TwoQubits));
            this.ThreeStates_TwoQubits_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ThreeStates_TwoQubits_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T10_ThreeStates_TwoQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T11_ZeroAndBitstringSuperposition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_ZeroAndBitstringSuperposition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_ZeroAndBitstringSuperposition_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T11_ZeroAndBitstringSuperposition_Test";
        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> BellState_Reference
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> GHZ_State_Reference
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid> ZeroAndBitstringSuperposition
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Boolean>)> ZeroAndBitstringSuperposition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 133 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg1__) => (__arg1__, new QArray<Boolean>(true)))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (PlusState_Reference, __arg2__)))));
#line 134 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg3__) => (__arg3__, new QArray<Boolean>(true, true)))), BellState_Reference));
#line 135 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((3L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg4__) => (__arg4__, new QArray<Boolean>(true, true, true)))), GHZ_State_Reference));
#line 137 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            var b = new QArray<Boolean>(true, false);
#line 138 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg5__) => (__arg5__, b?.Copy()))), ZeroAndBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg6__) => (__arg6__, b?.Copy())))));
#line 140 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b = new QArray<Boolean>(true, false, true);
#line 141 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((3L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg7__) => (__arg7__, b?.Copy()))), ZeroAndBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg8__) => (__arg8__, b?.Copy())))));
#line 143 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b = new QArray<Boolean>(true, false, true, true, false, false);
#line 144 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((6L, ZeroAndBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg9__) => (__arg9__, b?.Copy()))), ZeroAndBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>)>((__arg10__) => (__arg10__, b?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.BellState_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(BellState_Reference));
            this.GHZ_State_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(GHZ_State_Reference));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
            this.ZeroAndBitstringSuperposition = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid>>(typeof(ZeroAndBitstringSuperposition));
            this.ZeroAndBitstringSuperposition_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Boolean>)>>(typeof(ZeroAndBitstringSuperposition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_ZeroAndBitstringSuperposition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_TwoBitstringSuperposition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_TwoBitstringSuperposition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_TwoBitstringSuperposition_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T12_TwoBitstringSuperposition_Test";
        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> ArrayWrapperOperationA
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> BellState_Reference
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> GHZ_State_Reference
        {
            get;
            set;
        }

        protected IAdjointable<Qubit> PlusState_Reference
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid> TwoBitstringSuperposition
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)> TwoBitstringSuperposition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 151 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((1L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg1__) => (__arg1__, new QArray<Boolean>(true), new QArray<Boolean>(false)))), ArrayWrapperOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (PlusState_Reference, __arg2__)))));
#line 152 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg3__) => (__arg3__, new QArray<Boolean>(false, false), new QArray<Boolean>(true, true)))), BellState_Reference));
#line 153 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((3L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg4__) => (__arg4__, new QArray<Boolean>(true, true, true), new QArray<Boolean>(false, false, false)))), GHZ_State_Reference));
#line 157 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            var b1 = new QArray<Boolean>(false, true);
#line 158 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            var b2 = new QArray<Boolean>(true, false);
#line 159 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg5__) => (__arg5__, b1?.Copy(), b2?.Copy()))), TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg6__) => (__arg6__, b1?.Copy(), b2?.Copy())))));
#line 161 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b1 = new QArray<Boolean>(true, true, false);
#line 162 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b2 = new QArray<Boolean>(false, true, true);
#line 163 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((3L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg7__) => (__arg7__, b1?.Copy(), b2?.Copy()))), TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg8__) => (__arg8__, b1?.Copy(), b2?.Copy())))));
#line 166 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b1 = new QArray<Boolean>(false, true, true, false);
#line 167 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b2 = new QArray<Boolean>(false, true, true, true);
#line 168 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg9__) => (__arg9__, b1?.Copy(), b2?.Copy()))), TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg10__) => (__arg10__, b1?.Copy(), b2?.Copy())))));
#line 171 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b1 = new QArray<Boolean>(true, false, false, false);
#line 172 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            b2 = new QArray<Boolean>(true, false, true, true);
#line 173 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, TwoBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg11__) => (__arg11__, b1?.Copy(), b2?.Copy()))), TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg12__) => (__arg12__, b1?.Copy(), b2?.Copy())))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ArrayWrapperOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(ArrayWrapperOperationA));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.BellState_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(BellState_Reference));
            this.GHZ_State_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(GHZ_State_Reference));
            this.PlusState_Reference = this.Factory.Get<IAdjointable<Qubit>>(typeof(PlusState_Reference));
            this.TwoBitstringSuperposition = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid>>(typeof(TwoBitstringSuperposition));
            this.TwoBitstringSuperposition_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>>(typeof(TwoBitstringSuperposition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_TwoBitstringSuperposition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_FourBitstringSuperposition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_FourBitstringSuperposition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_FourBitstringSuperposition_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T13_FourBitstringSuperposition_Test";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<IQArray<Boolean>>), QVoid> FourBitstringSuperposition
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<IQArray<Boolean>>)> FourBitstringSuperposition_Reference
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 181 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            var bits = new QArray<IQArray<Boolean>>(new QArray<Boolean>(false, false), new QArray<Boolean>(false, true), new QArray<Boolean>(true, false), new QArray<Boolean>(true, true));
#line 182 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, FourBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<IQArray<Boolean>>)>((__arg1__) => (__arg1__, bits?.Copy()))), MicrosoftQuantumCanonApplyToEachA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (MicrosoftQuantumIntrinsicH, __arg2__)))));
#line 183 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            bits = new QArray<IQArray<Boolean>>(new QArray<Boolean>(false, false, false, true), new QArray<Boolean>(false, false, true, false), new QArray<Boolean>(false, true, false, false), new QArray<Boolean>(true, false, false, false));
#line 184 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, FourBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<IQArray<Boolean>>)>((__arg3__) => (__arg3__, bits?.Copy()))), WState_Arbitrary_Reference));
#line 187 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var N in new Range(3L, 10L))
#line hidden
            {
#line 189 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                var numbers = QArray<Int64>.Create(4L);
#line 191 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                while (true)
                {
#line 192 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    var ok = true;
#line 193 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 194 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                        numbers.Modify(i, MicrosoftQuantumMathRandomInt.Apply((1L << (int)N)));
#line 195 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                        foreach (var j in new Range(0L, (i - 1L)))
#line hidden
                        {
#line 196 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                            if ((numbers[i] == numbers[j]))
                            {
#line 197 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                                ok = false;
                            }
                        }
                    }

                    if (ok)
                    {
                        break;
                    }
                    else
                    {
                    }
                }

#line 206 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                foreach (var i in new Range(0L, 3L))
#line hidden
                {
#line 207 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    bits.Modify(i, MicrosoftQuantumConvertIntAsBoolArray.Apply((numbers[i], N)));
                }

#line 210 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((N, FourBitstringSuperposition.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<IQArray<Boolean>>)>((__arg4__) => (__arg4__, bits?.Copy()))), FourBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<IQArray<Boolean>>)>((__arg5__) => (__arg5__, bits?.Copy())))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.FourBitstringSuperposition = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<IQArray<Boolean>>), QVoid>>(typeof(FourBitstringSuperposition));
            this.FourBitstringSuperposition_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<IQArray<Boolean>>)>>(typeof(FourBitstringSuperposition_Reference));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_FourBitstringSuperposition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_WState_PowerOfTwo_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_WState_PowerOfTwo_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_WState_PowerOfTwo_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T14_WState_PowerOfTwo_Test";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)> MicrosoftQuantumIntrinsicAssert
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

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)> TwoBitstringSuperposition_Reference
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> WState_PowerOfTwo
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> WState_PowerOfTwo_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 218 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                var qs = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 219 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    WState_PowerOfTwo.Apply(qs);
#line 220 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    MicrosoftQuantumIntrinsicAssert.Apply((new QArray<Pauli>(Pauli.PauliZ), qs, Result.One, ""));
#line 221 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
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

#line 224 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, WState_PowerOfTwo, TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg3__) => (__arg3__, new QArray<Boolean>(false, true), new QArray<Boolean>(true, false))))));
#line 225 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, WState_PowerOfTwo, WState_PowerOfTwo_Reference));
#line 226 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((8L, WState_PowerOfTwo, WState_PowerOfTwo_Reference));
#line 227 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((16L, WState_PowerOfTwo, WState_PowerOfTwo_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicAssert = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Intrinsic.Assert));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.TwoBitstringSuperposition_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>>(typeof(TwoBitstringSuperposition_Reference));
            this.WState_PowerOfTwo = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(WState_PowerOfTwo));
            this.WState_PowerOfTwo_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(WState_PowerOfTwo_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_WState_PowerOfTwo_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T15_WState_Arbitrary_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T15_WState_Arbitrary_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T15_WState_Arbitrary_Test";
        String ICallable.FullName => "Quantum.Kata.Superposition.T15_WState_Arbitrary_Test";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)> MicrosoftQuantumIntrinsicAssert
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

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)> TwoBitstringSuperposition_Reference
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> WState_Arbitrary
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> WState_PowerOfTwo_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 234 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                var qs = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 235 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    WState_Arbitrary_Reference.Apply(qs);
#line 236 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    MicrosoftQuantumIntrinsicAssert.Apply((new QArray<Pauli>(Pauli.PauliZ), qs, Result.One, ""));
#line 237 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
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

#line 241 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, WState_Arbitrary, TwoBitstringSuperposition_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg3__) => (__arg3__, new QArray<Boolean>(false, true), new QArray<Boolean>(true, false))))));
#line 242 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, WState_Arbitrary, WState_PowerOfTwo_Reference));
#line 243 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, WState_Arbitrary, WState_PowerOfTwo_Reference));
#line 244 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((8L, WState_Arbitrary, WState_PowerOfTwo_Reference));
#line 245 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            AssertEqualOnZeroState.Apply((16L, WState_Arbitrary, WState_PowerOfTwo_Reference));
#line 247 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
            foreach (var i in new Range(2L, 16L))
#line hidden
            {
#line 248 "G:\\量子实习\\quantumKatas-VS\\Superposition\\Tests.qs"
                AssertEqualOnZeroState.Apply((i, WState_Arbitrary, WState_Arbitrary_Reference));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicAssert = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,String)>>(typeof(Microsoft.Quantum.Intrinsic.Assert));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.TwoBitstringSuperposition_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>>(typeof(TwoBitstringSuperposition_Reference));
            this.WState_Arbitrary = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(WState_Arbitrary));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
            this.WState_PowerOfTwo_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(WState_PowerOfTwo_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T15_WState_Arbitrary_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}