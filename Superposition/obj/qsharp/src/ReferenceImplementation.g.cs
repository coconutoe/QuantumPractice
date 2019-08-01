#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"PlusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"PlusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"PlusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":56}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.PlusState_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"MinusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Qubit\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"MinusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"MinusState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":57}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.MinusState_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"UnequalSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"UnequalSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"UnequalSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":83}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.UnequalSuperposition_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectors_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectors_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectors_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":75}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.AllBasisVectors_TwoQubits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsWithPhases_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":62,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":56}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsWithPhases_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":62,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":56}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsWithPhases_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":62,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":82},\"Item2\":{\"Line\":1,\"Column\":85}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.AllBasisVectorsWithPhases_TwoQubits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"BellState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"BellState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"BellState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":59}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.BellState_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBellStates_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"index\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBellStates_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBellStates_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":103,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":76}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.AllBellStates_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":59}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.GHZ_State_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"AllBasisVectorsSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":75},\"Item2\":{\"Line\":1,\"Column\":78}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.AllBasisVectorsSuperposition_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ThreeStates_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ThreeStates_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ThreeStates_TwoQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":148,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":71}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.ThreeStates_TwoQubits_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ThreeStates_TwoQubits_Postselection\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ThreeStates_TwoQubits_Postselection\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":161,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ZeroAndBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":50}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ZeroAndBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":50}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"ZeroAndBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":94}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.ZeroAndBitstringSuperposition_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FindFirstDiff_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":217,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FindFirstDiff_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":217,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"TwoBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":228,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":83}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"TwoBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":228,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"TwoBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":228,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":104},\"Item2\":{\"Line\":1,\"Column\":107}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.TwoBitstringSuperposition_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FourBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":266,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":67}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FourBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":266,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FourBitstringSuperposition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":266,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":93}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.FourBitstringSuperposition_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_PowerOfTwo_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":301,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_PowerOfTwo_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":301,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_PowerOfTwo_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":301,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":67}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.WState_PowerOfTwo_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.WState_Arbitrary_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.Superposition.WState_Arbitrary_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":338,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.Superposition.WState_Arbitrary_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Iterative\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":362,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Iterative\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":362,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Iterative\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":362,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":66}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.WState_Arbitrary_Iterative\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FractionSuperposition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":372,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"denominator\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FractionSuperposition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":372,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FractionSuperposition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":372,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":82}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Superposition.FractionSuperposition\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FractionSuperposition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":372,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":82}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.Superposition.FractionSuperposition\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"FractionSuperposition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":372,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":82}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.Superposition.FractionSuperposition\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Postselect\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":387,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Superposition\",\"Name\":\"WState_Arbitrary_Postselect\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Superposition/ReferenceImplementation.qs\",\"Position\":{\"Item1\":387,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Superposition
{
    public partial class PlusState_Reference : Adjointable<Qubit>, ICallable
    {
        public PlusState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PlusState_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.PlusState_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 26 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in__) =>
        {
            var q = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<PlusState_Reference, Qubit, QVoid>(q);
        }
    }

    public partial class MinusState_Reference : Adjointable<Qubit>, ICallable
    {
        public MinusState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MinusState_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.MinusState_Reference";
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

        public override Func<Qubit, QVoid> Body => (__in__) =>
        {
            var q = __in__;
#line 34 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicX.Apply(q);
#line 35 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<Qubit, QVoid> AdjointBody => (__in__) =>
        {
            var q = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(q);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<MinusState_Reference, Qubit, QVoid>(q);
        }
    }

    public partial class UnequalSuperposition_Reference : Adjointable<(Qubit,Double)>, ICallable
    {
        public UnequalSuperposition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Double)>, IApplyData
        {
            public In((Qubit,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "UnequalSuperposition_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.UnequalSuperposition_Reference";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        public override Func<(Qubit,Double), QVoid> Body => (__in__) =>
        {
            var (q,alpha) = __in__;
#line 47 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (q,alpha) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
        }

        public override IApplyData __dataIn((Qubit,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Double alpha)
        {
            return __m__.Run<UnequalSuperposition_Reference, (Qubit,Double), QVoid>((q, alpha));
        }
    }

    public partial class AllBasisVectors_TwoQubits_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public AllBasisVectors_TwoQubits_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AllBasisVectors_TwoQubits_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.AllBasisVectors_TwoQubits_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 57 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 58 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[1L]);
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<AllBasisVectors_TwoQubits_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class AllBasisVectorsWithPhases_TwoQubits_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public AllBasisVectorsWithPhases_TwoQubits_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AllBasisVectorsWithPhases_TwoQubits_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.AllBasisVectorsWithPhases_TwoQubits_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
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
#line 77 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 78 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicZ.Apply(qs[0L]);
#line 81 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 82 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicS.Apply(qs[1L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumIntrinsicS.Adjoint.Apply(qs[1L]);
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[1L]);
#line hidden
            MicrosoftQuantumIntrinsicZ.Adjoint.Apply(qs[0L]);
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<AllBasisVectorsWithPhases_TwoQubits_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class BellState_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public BellState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BellState_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.BellState_Reference";
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

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 90 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 91 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<BellState_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class AllBellStates_Reference : Adjointable<(IQArray<Qubit>,Int64)>, ICallable
    {
        public AllBellStates_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "AllBellStates_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.AllBellStates_Reference";
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

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,index) = __in__;
#line 106 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 107 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 110 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if (((index % 2L) == 1L))
            {
#line 112 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicZ.Apply(qs[1L]);
            }

#line 114 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if (((index / 2L) == 1L))
            {
#line 115 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,index) = __in__;
#line hidden
            if (((index / 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[1L]);
            }

#line hidden
            if (((index % 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicZ.Adjoint.Apply(qs[1L]);
            }

#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 index)
        {
            return __m__.Run<AllBellStates_Reference, (IQArray<Qubit>,Int64), QVoid>((qs, index));
        }
    }

    public partial class GHZ_State_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public GHZ_State_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZ_State_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.GHZ_State_Reference";
        protected ICallable MicrosoftQuantumArraysRest
        {
            get;
            set;
        }

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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 125 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 127 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var q in MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs))
#line hidden
            {
#line 128 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            foreach (var q in MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs)?.Slice(new Range((MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs).Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], q));
            }

#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysRest = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Rest<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<GHZ_State_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class AllBasisVectorsSuperposition_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public AllBasisVectorsSuperposition_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AllBasisVectorsSuperposition_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.AllBasisVectorsSuperposition_Reference";
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
            var qs = __in__;
#line 139 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var q in qs)
#line hidden
            {
#line 140 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            foreach (var q in qs?.Slice(new Range((qs.Length - 1L), -1L, 0L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicH.Adjoint.Apply(q);
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<AllBasisVectorsSuperposition_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ThreeStates_TwoQubits_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ThreeStates_TwoQubits_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ThreeStates_TwoQubits_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.ThreeStates_TwoQubits_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 154 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(3D)));
#line 155 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((2D * theta), qs[0L]));
#line 158 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumIntrinsicH)).Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(3D)));
#line hidden
            MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, MicrosoftQuantumIntrinsicH)).Adjoint.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * theta), qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ThreeStates_TwoQubits_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ThreeStates_TwoQubits_Postselection : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ThreeStates_TwoQubits_Postselection(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ThreeStates_TwoQubits_Postselection";
        String ICallable.FullName => "Quantum.Kata.Superposition.ThreeStates_TwoQubits_Postselection";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            {
#line 163 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var ancilla = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 164 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    while (true)
                    {
#line 166 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, qs));
#line 168 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicX.Controlled.Apply((qs, ancilla));
#line 169 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        var res = MicrosoftQuantumMeasurementMResetZ.Apply(ancilla);
                        if ((res == Result.Zero))
                        {
                            break;
                        }
                        else
                        {
#line 173 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                        }
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
                    Release.Apply(ancilla);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ThreeStates_TwoQubits_Postselection, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ZeroAndBitstringSuperposition_Reference : Adjointable<(IQArray<Qubit>,IQArray<Boolean>)>, ICallable
    {
        public ZeroAndBitstringSuperposition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "ZeroAndBitstringSuperposition_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.ZeroAndBitstringSuperposition_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
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

        public override Func<(IQArray<Qubit>,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (qs,bits) = __in__;
#line 191 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((bits.Length, qs.Length, "Arrays should have the same length"));
#line 192 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((bits[0L], true, "First bit of the input bit string should be set to true"));
#line 195 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 198 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var i in new Range(1L, (qs.Length - 1L)))
#line hidden
            {
#line 199 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                if (bits[i])
                {
#line 200 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Boolean>), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,bits) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((bits.Length, qs.Length, "Arrays should have the same length"));
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((bits[0L], true, "First bit of the input bit string should be set to true"));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (qs.Length - 1L))))
#line hidden
            {
#line hidden
                if (bits[i])
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[i]));
                }
            }

#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits)
        {
            return __m__.Run<ZeroAndBitstringSuperposition_Reference, (IQArray<Qubit>,IQArray<Boolean>), QVoid>((qs, bits));
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
        String ICallable.FullName => "Quantum.Kata.Superposition.FindFirstDiff_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>), Int64> Body => (__in__) =>
        {
            var (bits1,bits2) = __in__;
#line 219 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var firstDiff = -(1L);
#line 220 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var i in new Range(0L, (bits1.Length - 1L)))
#line hidden
            {
#line 221 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                if (((bits1[i] != bits2[i]) && (firstDiff == -(1L))))
                {
#line 222 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    firstDiff = i;
                }
            }

#line 225 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            return firstDiff;
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

    public partial class TwoBitstringSuperposition_Reference : Adjointable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>, ICallable
    {
        public TwoBitstringSuperposition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "TwoBitstringSuperposition_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.TwoBitstringSuperposition_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64> FindFirstDiff_Reference
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (qs,bits1,bits2) = __in__;
#line 232 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var firstDiff = FindFirstDiff_Reference.Apply((bits1, bits2));
#line 235 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[firstDiff]);
#line 238 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var i in new Range(0L, (qs.Length - 1L)))
#line hidden
            {
#line 239 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                if ((bits1[i] == bits2[i]))
                {
#line 241 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    if (bits1[i])
                    {
#line 242 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicX.Apply(qs[i]);
                    }
                }
                else
                {
#line 246 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    if ((i > firstDiff))
                    {
#line 247 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((qs[firstDiff], qs[i]));
#line 248 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        if ((bits1[i] != bits1[firstDiff]))
                        {
#line 249 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumIntrinsicX.Apply(qs[i]);
                        }
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,bits1,bits2) = __in__;
#line hidden
            var firstDiff = FindFirstDiff_Reference.Apply((bits1, bits2));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (qs.Length - 1L))))
#line hidden
            {
#line hidden
                if ((bits1[i] == bits2[i]))
                {
#line hidden
                    if (bits1[i])
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[i]);
                    }
                }
                else
                {
#line hidden
                    if ((i > firstDiff))
                    {
#line hidden
                        if ((bits1[i] != bits1[firstDiff]))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[i]);
                        }

#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[firstDiff], qs[i]));
                    }
                }
            }

#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[firstDiff]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.FindFirstDiff_Reference = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64>>(typeof(FindFirstDiff_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits1, IQArray<Boolean> bits2)
        {
            return __m__.Run<TwoBitstringSuperposition_Reference, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid>((qs, bits1, bits2));
        }
    }

    public partial class FourBitstringSuperposition_Reference : Adjointable<(IQArray<Qubit>,IQArray<IQArray<Boolean>>)>, ICallable
    {
        public FourBitstringSuperposition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<IQArray<Boolean>>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<IQArray<Boolean>>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "FourBitstringSuperposition_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.FourBitstringSuperposition_Reference";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnBitString
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

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

        public override Func<(IQArray<Qubit>,IQArray<IQArray<Boolean>>), QVoid> Body => (__in__) =>
        {
            var (qs,bits) = __in__;
#line 268 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var N = qs.Length;
#line hidden
            {
#line 270 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var anc = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 272 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, anc));
#line 275 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 276 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        foreach (var j in new Range(0L, (N - 1L)))
#line hidden
                        {
#line 277 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            if (bits[i][j])
                            {
#line 278 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumIntrinsicX)).Apply((anc, qs[j]));
                            }
                        }
                    }

#line 284 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    foreach (var i in new Range(0L, 3L))
#line hidden
                    {
#line 285 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        if (((i % 2L) == 1L))
                        {
#line 286 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bits[i], MicrosoftQuantumIntrinsicX)).Apply((qs, anc[0L]));
                        }

#line 288 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        if (((i / 2L) == 1L))
                        {
#line 289 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bits[i], MicrosoftQuantumIntrinsicX)).Apply((qs, anc[1L]));
                        }
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
                    Release.Apply(anc);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<IQArray<Boolean>>), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,bits) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            {
#line hidden
                var anc = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    foreach (var i in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
                    {
#line hidden
                        if (((i / 2L) == 1L))
                        {
#line hidden
                            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bits[i], MicrosoftQuantumIntrinsicX)).Adjoint.Apply((qs, anc[1L]));
                        }

#line hidden
                        if (((i % 2L) == 1L))
                        {
#line hidden
                            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((bits[i], MicrosoftQuantumIntrinsicX)).Adjoint.Apply((qs, anc[0L]));
                        }
                    }

#line hidden
                    foreach (var i in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
                    {
#line hidden
                        foreach (var j in RangeReverse.Apply(new Range(0L, (N - 1L))))
#line hidden
                        {
#line hidden
                            if (bits[i][j])
                            {
#line hidden
                                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((i, MicrosoftQuantumIntrinsicX)).Adjoint.Apply((anc, qs[j]));
                            }
                        }
                    }

#line hidden
                    MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, anc));
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<IQArray<Boolean>>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<IQArray<Boolean>> bits)
        {
            return __m__.Run<FourBitstringSuperposition_Reference, (IQArray<Qubit>,IQArray<IQArray<Boolean>>), QVoid>((qs, bits));
        }
    }

    public partial class WState_PowerOfTwo_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public WState_PowerOfTwo_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_PowerOfTwo_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.WState_PowerOfTwo_Reference";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
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

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> self
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 304 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var N = qs.Length;
#line 306 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if ((N == 1L))
            {
#line 308 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }
            else
            {
#line 310 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var K = (N / 2L);
#line 313 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                self.Apply(qs?.Slice(new Range(0L, (K - 1L))));
#line hidden
                {
#line 317 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    var anc = Allocate.Apply();
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 318 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicH.Apply(anc);
#line 320 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        foreach (var i in new Range(0L, (K - 1L)))
#line hidden
                        {
#line 321 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Apply((new QArray<Qubit>(anc), (qs[i], qs[(i + K)])));
                        }

#line 323 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        foreach (var i in new Range(K, (N - 1L)))
#line hidden
                        {
#line 324 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            MicrosoftQuantumIntrinsicCNOT.Apply((qs[i], anc));
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
                        Release.Apply(anc);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
            }
            else
            {
#line hidden
                var K = (N / 2L);
#line hidden
                {
#line hidden
                    var anc = Allocate.Apply();
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line hidden
                        foreach (var i in RangeReverse.Apply(new Range(K, (N - 1L))))
#line hidden
                        {
#line hidden
                            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[i], anc));
                        }

#line hidden
                        foreach (var i in RangeReverse.Apply(new Range(0L, (K - 1L))))
#line hidden
                        {
#line hidden
                            MicrosoftQuantumIntrinsicSWAP.Controlled.Adjoint.Apply((new QArray<Qubit>(anc), (qs[i], qs[(i + K)])));
                        }

#line hidden
                        MicrosoftQuantumIntrinsicH.Adjoint.Apply(anc);
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

#line hidden
                self.Adjoint.Apply(qs?.Slice(new Range(0L, (K - 1L))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.self = this;
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<WState_PowerOfTwo_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class WState_Arbitrary_Reference : Unitary<IQArray<Qubit>>, ICallable
    {
        public WState_Arbitrary_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary_Reference";
        String ICallable.FullName => "Quantum.Kata.Superposition.WState_Arbitrary_Reference";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathArcSin
        {
            get;
            set;
        }

        protected ICallable<Double, Double> MicrosoftQuantumMathSqrt
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> self
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 341 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var N = qs.Length;
#line 343 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if ((N == 1L))
            {
#line 345 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }
            else
            {
#line 350 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line 351 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * theta), qs[0L]));
#line 354 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 355 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 356 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
#line hidden
                self.Controlled.Adjoint.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
#line hidden
                MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * theta), qs[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[0L]));
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line hidden
                MicrosoftQuantumIntrinsicRy.Controlled.Apply((__controlQubits__, ((2D * theta), qs[0L])));
#line hidden
                MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
                self.Controlled.Controlled.Apply((__controlQubits__, (qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L))))));
#line hidden
                MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            if ((N == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
            }
            else
            {
#line hidden
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
                self.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L))))));
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
                MicrosoftQuantumIntrinsicRy.Adjoint.Controlled.Apply((__controlQubits__, ((2D * theta), qs[0L])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathArcSin = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcSin));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
            this.self = this;
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<WState_Arbitrary_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class WState_Arbitrary_Iterative : Adjointable<IQArray<Qubit>>, ICallable
    {
        public WState_Arbitrary_Iterative(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary_Iterative";
        String ICallable.FullName => "Quantum.Kata.Superposition.WState_Arbitrary_Iterative";
        protected ICallable MicrosoftQuantumCanonControlledOnInt
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Qubit)> FractionSuperposition
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 364 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var N = qs.Length;
#line 365 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            FractionSuperposition.Apply((N, qs[0L]));
#line 366 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            foreach (var i in new Range(1L, (N - 1L)))
#line hidden
            {
#line 367 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, FractionSuperposition)).Apply((qs?.Slice(new Range(0L, (i - 1L))), ((N - i), qs[i])));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            var N = qs.Length;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (N - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumCanonControlledOnInt.Apply<IUnitary>((0L, FractionSuperposition)).Adjoint.Apply((qs?.Slice(new Range(0L, (i - 1L))), ((N - i), qs[i])));
            }

#line hidden
            FractionSuperposition.Adjoint.Apply((N, qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnInt = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnInt<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.FractionSuperposition = this.Factory.Get<IUnitary<(Int64,Qubit)>>(typeof(FractionSuperposition));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<WState_Arbitrary_Iterative, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class FractionSuperposition : Unitary<(Int64,Qubit)>, ICallable
    {
        public FractionSuperposition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit)>, IApplyData
        {
            public In((Int64,Qubit) data) : base(data)
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

        String ICallable.Name => "FractionSuperposition";
        String ICallable.FullName => "Quantum.Kata.Superposition.FractionSuperposition";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
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

        public override Func<(Int64,Qubit), QVoid> Body => (__in__) =>
        {
            var (denominator,q) = __in__;
#line 375 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if ((denominator == 1L))
            {
#line 376 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
            }
            else
            {
#line 379 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var denom = MicrosoftQuantumConvertIntAsDouble.Apply(denominator);
#line 380 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var num = (denom - 1D);
#line 381 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var theta = MicrosoftQuantumMathArcCos.Apply(MicrosoftQuantumMathSqrt.Apply((num / denom)));
#line 382 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * theta), q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Int64,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (denominator,q) = __in__;
#line hidden
            if ((denominator == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
            }
            else
            {
#line hidden
                var denom = MicrosoftQuantumConvertIntAsDouble.Apply(denominator);
#line hidden
                var num = (denom - 1D);
#line hidden
                var theta = MicrosoftQuantumMathArcCos.Apply(MicrosoftQuantumMathSqrt.Apply((num / denom)));
#line hidden
                MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * theta), q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(denominator,q)) = __in__;
#line hidden
            if ((denominator == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, q));
            }
            else
            {
#line hidden
                var denom = MicrosoftQuantumConvertIntAsDouble.Apply(denominator);
#line hidden
                var num = (denom - 1D);
#line hidden
                var theta = MicrosoftQuantumMathArcCos.Apply(MicrosoftQuantumMathSqrt.Apply((num / denom)));
#line hidden
                MicrosoftQuantumIntrinsicRy.Controlled.Apply((__controlQubits__, ((2D * theta), q)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Int64,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(denominator,q)) = __in__;
#line hidden
            if ((denominator == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, q));
            }
            else
            {
#line hidden
                var denom = MicrosoftQuantumConvertIntAsDouble.Apply(denominator);
#line hidden
                var num = (denom - 1D);
#line hidden
                var theta = MicrosoftQuantumMathArcCos.Apply(MicrosoftQuantumMathSqrt.Apply((num / denom)));
#line hidden
                MicrosoftQuantumIntrinsicRy.Adjoint.Controlled.Apply((__controlQubits__, ((2D * theta), q)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumMathArcCos = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.ArcCos));
            this.MicrosoftQuantumMathSqrt = this.Factory.Get<ICallable<Double, Double>>(typeof(Microsoft.Quantum.Math.Sqrt));
        }

        public override IApplyData __dataIn((Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 denominator, Qubit q)
        {
            return __m__.Run<FractionSuperposition, (Int64,Qubit), QVoid>((denominator, q));
        }
    }

    public partial class WState_Arbitrary_Postselect : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public WState_Arbitrary_Postselect(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary_Postselect";
        String ICallable.FullName => "Quantum.Kata.Superposition.WState_Arbitrary_Postselect";
        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultZero
        {
            get;
            set;
        }

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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> WState_PowerOfTwo_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 389 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            var N = qs.Length;
#line 391 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
            if ((N == 1L))
            {
#line 393 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }
            else
            {
#line 397 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                var P = 1L;
#line 398 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                foreach (var i in new Range(1L, 6L))
#line hidden
                {
#line 399 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    if ((P < N))
                    {
#line 400 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        P = (P * 2L);
                    }
                }

#line 404 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                if ((P == N))
                {
#line 406 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                    WState_PowerOfTwo_Reference.Apply(qs);
                }
                else
                {
#line hidden
                    {
#line 409 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                        var anc = Allocate.Apply((P - N));
#line hidden
                        Exception __arg1__ = null;
                        try
                        {
#line 410 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            var all_qubits = (IQArray<Qubit>)QArray<Qubit>.Add(qs, anc);
#line 412 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                            while (true)
                            {
#line 414 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                WState_PowerOfTwo_Reference.Apply(all_qubits);
#line 417 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                var allZeros = true;
#line 418 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                foreach (var i in new Range(0L, ((P - N) - 1L)))
#line hidden
                                {
#line 419 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                    if (!(MicrosoftQuantumCanonIsResultZero.Apply(MicrosoftQuantumIntrinsicM.Apply(anc[i]))))
                                    {
#line 420 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                        allZeros = false;
                                    }
                                }

                                if (allZeros)
                                {
                                    break;
                                }
                                else
                                {
#line 426 "G:\\量子实习\\quantumKatas-VS\\Superposition\\ReferenceImplementation.qs"
                                    MicrosoftQuantumIntrinsicResetAll.Apply(anc);
                                }
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
                            Release.Apply(anc);
                        }
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonIsResultZero = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.IsResultZero));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.WState_PowerOfTwo_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(WState_PowerOfTwo_Reference));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<WState_Arbitrary_Postselect, IQArray<Qubit>, QVoid>(qs);
        }
    }
}