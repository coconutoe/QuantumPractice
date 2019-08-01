#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishTwoStates_OneQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":86}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishTwoStates_OneQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T101_IsQubitOne_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T101_IsQubitOne_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T102_InitializeQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T102_InitializeQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T103_IsQubitPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T103_IsQubitPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T104_IsQubitA_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T104_IsQubitA_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishStates_MultiQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nqubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nstate\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":45},\"Item2\":{\"Line\":2,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":45},\"Item2\":{\"Line\":3,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":45},\"Item2\":{\"Line\":4,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"measurementsPerRun\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":45},\"Item2\":{\"Line\":5,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishStates_MultiQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_ZeroZeroOrOneOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_ZeroZeroOrOneOne\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T105_ZeroZeroOrOneOne_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":185,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T105_ZeroZeroOrOneOne_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":185,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_BasisStateMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_BasisStateMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T106_BasisStateMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T106_BasisStateMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":205,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_Bitstring\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":211,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_Bitstring\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":211,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":93},\"Item2\":{\"Line\":1,\"Column\":98}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"CheckTwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":226,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b1\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b2\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"CheckTwoBitstringsMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":226,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T107_TwoBitstringsMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":231,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T107_TwoBitstringsMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":231,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":240,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":240,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":240,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Measurements.WState_Arbitrary_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":240,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.Measurements.WState_Arbitrary_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"WState_Arbitrary_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":240,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.Measurements.WState_Arbitrary_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_AllZerosOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":262,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_AllZerosOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":262,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T108_AllZerosOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":271,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T108_AllZerosOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":271,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":280,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":280,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"GHZ_State_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":280,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Measurements.GHZ_State_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":290,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T109_GHZOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":302,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T109_GHZOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":302,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":314,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":314,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T110_BellState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":329,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T110_BellState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":329,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoQubitState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":339,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoQubitState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":339,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T111_TwoQubitState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":347,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T111_TwoQubitState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":347,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoQubitStatePartTwo\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_TwoQubitStatePartTwo\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":357,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T112_TwoQubitStatePartTwo_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":374,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T112_TwoQubitStatePartTwo_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":374,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_ThreeQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":381,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_ThreeQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":381,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_ThreeQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":381,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.Measurements.StatePrep_ThreeQubitMeasurement\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T113_ThreeQubitMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":397,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T113_ThreeQubitMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":397,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitZeroOrPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":406,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitZeroOrPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":406,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":417,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nqubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nstate\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"threshold\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":88}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":108}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":135},\"Item2\":{\"Line\":1,\"Column\":143}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Double\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":417,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":49}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T201_IsQubitZeroOrPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":446,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T201_IsQubitZeroOrPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":446,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"USD_DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":456,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nqubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nstate\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":75}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"thresholdInconcl\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":99}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"thresholdConcl\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":124}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":135},\"Item2\":{\"Line\":1,\"Column\":144}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":171},\"Item2\":{\"Line\":1,\"Column\":179}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Double\"},{\"Case\":\"Double\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"USD_DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":456,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T202_IsQubitZeroOrPlusSimpleUSD_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":522,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T202_IsQubitZeroOrPlusSimpleUSD_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":522,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitNotInABC\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":528,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"StatePrep_IsQubitNotInABC\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":528,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ABC_DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":550,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nqubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nstate\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":75}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":92}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":119},\"Item2\":{\"Line\":1,\"Column\":127}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"ABC_DistinguishStates_MultiQubit_Threshold\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":550,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":53}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T203_IsQubitNotInABC_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":582,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Measurements\",\"Name\":\"T203_IsQubitNotInABC_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Measurements/Tests.qs\",\"Position\":{\"Item1\":582,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Measurements
{
    public partial class DistinguishTwoStates_OneQubit : Operation<(ICallable,ICallable), QVoid>, ICallable
    {
        public DistinguishTwoStates_OneQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable)>, IApplyData
        {
            public In((ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DistinguishTwoStates_OneQubit";
        String ICallable.FullName => "Quantum.Kata.Measurements.DistinguishTwoStates_OneQubit";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomIntPow2
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (statePrep,testImpl) = __in__;
#line 25 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nTotal = 100L;
#line 26 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nOk = 0L;
#line hidden
            {
#line 28 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 29 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 33 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomIntPow2.Apply(1L);
#line 36 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        statePrep.Apply((qs[0L], state));
#line 39 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var ans = testImpl.Apply<Boolean>(qs[0L]);
#line 40 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((ans == (state == 1L)))
                        {
#line 41 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nOk = (nOk + 1L);
                        }

#line 45 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicReset.Apply(qs[0L]);
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
                    Release.Apply(qs);
                }
            }

#line 49 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nOk, nTotal, String.Format("{0} test runs out of {1} returned incorrect state.", (nTotal - nOk), nTotal)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumMathRandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomIntPow2));
        }

        public override IApplyData __dataIn((ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable statePrep, ICallable testImpl)
        {
            return __m__.Run<DistinguishTwoStates_OneQubit, (ICallable,ICallable), QVoid>((statePrep, testImpl));
        }
    }

    public partial class StatePrep_IsQubitOne : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_IsQubitOne(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
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

        String ICallable.Name => "StatePrep_IsQubitOne";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_IsQubitOne";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q,state) = __in__;
#line 55 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state != 0L))
            {
#line 57 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Int64 state)
        {
            return __m__.Run<StatePrep_IsQubitOne, (Qubit,Int64), QVoid>((q, state));
        }
    }

    public partial class T101_IsQubitOne_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T101_IsQubitOne_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T101_IsQubitOne_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T101_IsQubitOne_Test";
        protected ICallable<(ICallable,ICallable), QVoid> DistinguishTwoStates_OneQubit
        {
            get;
            set;
        }

        protected ICallable<Qubit, Boolean> IsQubitOne
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitOne
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 63 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishTwoStates_OneQubit.Apply((StatePrep_IsQubitOne, IsQubitOne));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishTwoStates_OneQubit = this.Factory.Get<ICallable<(ICallable,ICallable), QVoid>>(typeof(DistinguishTwoStates_OneQubit));
            this.IsQubitOne = this.Factory.Get<ICallable<Qubit, Boolean>>(typeof(IsQubitOne));
            this.StatePrep_IsQubitOne = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitOne));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T101_IsQubitOne_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T102_InitializeQubit_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T102_InitializeQubit_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T102_InitializeQubit_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T102_InitializeQubit_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

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

        protected ICallable<Qubit, QVoid> InitializeQubit
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 69 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(1L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 70 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(0L, 36L))
#line hidden
                    {
#line 71 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 72 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), qs[0L]));
#line 75 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        InitializeQubit.Apply(qs[0L]);
#line 78 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumDiagnosticsAssertAllZero.Apply(qs);
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
                    Release.Apply(qs);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.InitializeQubit = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(InitializeQubit));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T102_InitializeQubit_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_IsQubitPlus : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_IsQubitPlus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
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

        String ICallable.Name => "StatePrep_IsQubitPlus";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_IsQubitPlus";
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

        public override Func<(Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q,state) = __in__;
#line 86 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 0L))
            {
#line 88 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
#line 89 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }
            else
            {
#line 92 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Int64 state)
        {
            return __m__.Run<StatePrep_IsQubitPlus, (Qubit,Int64), QVoid>((q, state));
        }
    }

    public partial class T103_IsQubitPlus_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T103_IsQubitPlus_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T103_IsQubitPlus_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T103_IsQubitPlus_Test";
        protected ICallable<(ICallable,ICallable), QVoid> DistinguishTwoStates_OneQubit
        {
            get;
            set;
        }

        protected ICallable<Qubit, Boolean> IsQubitPlus
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitPlus
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 98 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishTwoStates_OneQubit.Apply((StatePrep_IsQubitPlus, IsQubitPlus));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishTwoStates_OneQubit = this.Factory.Get<ICallable<(ICallable,ICallable), QVoid>>(typeof(DistinguishTwoStates_OneQubit));
            this.IsQubitPlus = this.Factory.Get<ICallable<Qubit, Boolean>>(typeof(IsQubitPlus));
            this.StatePrep_IsQubitPlus = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitPlus));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T103_IsQubitPlus_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_IsQubitA : Operation<(Double,Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_IsQubitA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Qubit,Int64)>, IApplyData
        {
            public In((Double,Qubit,Int64) data) : base(data)
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

        String ICallable.Name => "StatePrep_IsQubitA";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_IsQubitA";
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

        public override Func<(Double,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (alpha,q,state) = __in__;
#line 106 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 0L))
            {
#line 108 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
#line 109 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), q));
            }
            else
            {
#line 112 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Double,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double alpha, Qubit q, Int64 state)
        {
            return __m__.Run<StatePrep_IsQubitA, (Double,Qubit,Int64), QVoid>((alpha, q, state));
        }
    }

    public partial class T104_IsQubitA_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T104_IsQubitA_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T104_IsQubitA_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T104_IsQubitA_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), QVoid> DistinguishTwoStates_OneQubit
        {
            get;
            set;
        }

        protected ICallable<(Double,Qubit), Boolean> IsQubitA
        {
            get;
            set;
        }

        protected ICallable<(Double,Qubit,Int64), QVoid> StatePrep_IsQubitA
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitOne
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitPlus
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 121 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishTwoStates_OneQubit.Apply((StatePrep_IsQubitOne, IsQubitA.Partial(new Func<Qubit, (Double,Qubit)>((__arg1__) => ((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 2D), __arg1__)))));
#line 124 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishTwoStates_OneQubit.Apply((StatePrep_IsQubitPlus, IsQubitA.Partial(new Func<Qubit, (Double,Qubit)>((__arg2__) => ((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 4D), __arg2__)))));
#line 126 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            foreach (var i in new Range(0L, 10L))
#line hidden
            {
#line 127 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var alpha = ((MicrosoftQuantumMathPI.Apply(QVoid.Instance) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 10D);
#line 128 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                DistinguishTwoStates_OneQubit.Apply((StatePrep_IsQubitA.Partial(new Func<(Qubit,Int64), (Double,Qubit,Int64)>((__arg3__) => (alpha, __arg3__.Item1, __arg3__.Item2))), IsQubitA.Partial(new Func<Qubit, (Double,Qubit)>((__arg4__) => (alpha, __arg4__)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.DistinguishTwoStates_OneQubit = this.Factory.Get<ICallable<(ICallable,ICallable), QVoid>>(typeof(DistinguishTwoStates_OneQubit));
            this.IsQubitA = this.Factory.Get<ICallable<(Double,Qubit), Boolean>>(typeof(IsQubitA));
            this.StatePrep_IsQubitA = this.Factory.Get<ICallable<(Double,Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitA));
            this.StatePrep_IsQubitOne = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitOne));
            this.StatePrep_IsQubitPlus = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitPlus));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T104_IsQubitA_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class DistinguishStates_MultiQubit : Operation<(Int64,Int64,ICallable,ICallable,Int64), QVoid>, ICallable
    {
        public DistinguishStates_MultiQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,ICallable,ICallable,Int64)>, IApplyData
        {
            public In((Int64,Int64,ICallable,ICallable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "DistinguishStates_MultiQubit";
        String ICallable.FullName => "Quantum.Kata.Measurements.DistinguishStates_MultiQubit";
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

        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
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

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable QuantumKataUtilsGetOracleCallsCount
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> QuantumKataUtilsResetOracleCallsCount
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,ICallable,ICallable,Int64), QVoid> Body => (__in__) =>
        {
            var (Nqubit,Nstate,statePrep,testImpl,measurementsPerRun) = __in__;
#line 142 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nTotal = 100L;
#line 143 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nOk = 0L;
#line hidden
            {
#line 145 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(Nqubit);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 146 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 148 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomInt.Apply(Nstate);
#line 151 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        statePrep.Apply((qs, state));
#line 153 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((measurementsPerRun > 0L))
                        {
#line 154 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            QuantumKataUtilsResetOracleCallsCount.Apply(QVoid.Instance);
                        }

#line 157 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var ans = testImpl.Apply<Int64>(qs);
#line 158 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((ans == state))
                        {
#line 159 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nOk = (nOk + 1L);
                        }

#line 162 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((measurementsPerRun > 0L))
                        {
#line 163 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            var nm = (QuantumKataUtilsGetOracleCallsCount.Apply<Int64>(MicrosoftQuantumIntrinsicM) + QuantumKataUtilsGetOracleCallsCount.Apply<Int64>(MicrosoftQuantumIntrinsicMeasure));
#line 164 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            MicrosoftQuantumDiagnosticsEqualityFactB.Apply(((nm <= 1L), true, String.Format("You are allowed to do at most one measurement, and you did {0}", nm)));
                        }

#line 168 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qs);
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
                    Release.Apply(qs);
                }
            }

#line 172 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nOk, nTotal, String.Format("{0} test runs out of {1} returned incorrect state.", (nTotal - nOk), nTotal)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.QuantumKataUtilsGetOracleCallsCount = this.Factory.Get<ICallable>(typeof(Quantum.Kata.Utils.GetOracleCallsCount<>));
            this.QuantumKataUtilsResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(Quantum.Kata.Utils.ResetOracleCallsCount));
        }

        public override IApplyData __dataIn((Int64,Int64,ICallable,ICallable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 Nqubit, Int64 Nstate, ICallable statePrep, ICallable testImpl, Int64 measurementsPerRun)
        {
            return __m__.Run<DistinguishStates_MultiQubit, (Int64,Int64,ICallable,ICallable,Int64), QVoid>((Nqubit, Nstate, statePrep, testImpl, measurementsPerRun));
        }
    }

    public partial class StatePrep_ZeroZeroOrOneOne : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_ZeroZeroOrOneOne(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_ZeroZeroOrOneOne";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_ZeroZeroOrOneOne";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 178 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 1L))
            {
#line 180 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 181 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_ZeroZeroOrOneOne, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T105_ZeroZeroOrOneOne_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T105_ZeroZeroOrOneOne_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T105_ZeroZeroOrOneOne_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T105_ZeroZeroOrOneOne_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_ZeroZeroOrOneOne
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> ZeroZeroOrOneOne
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 187 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 2L, StatePrep_ZeroZeroOrOneOne, ZeroZeroOrOneOne, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_ZeroZeroOrOneOne = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_ZeroZeroOrOneOne));
            this.ZeroZeroOrOneOne = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(ZeroZeroOrOneOne));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T105_ZeroZeroOrOneOne_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_BasisStateMeasurement : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_BasisStateMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_BasisStateMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_BasisStateMeasurement";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 194 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if (((state / 2L) == 1L))
            {
#line 196 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }

#line 199 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if (((state % 2L) == 1L))
            {
#line 201 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_BasisStateMeasurement, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T106_BasisStateMeasurement_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T106_BasisStateMeasurement_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T106_BasisStateMeasurement_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T106_BasisStateMeasurement_Test";
        protected ICallable<IQArray<Qubit>, Int64> BasisStateMeasurement
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_BasisStateMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 207 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 4L, StatePrep_BasisStateMeasurement, BasisStateMeasurement, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BasisStateMeasurement = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(BasisStateMeasurement));
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_BasisStateMeasurement = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_BasisStateMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T106_BasisStateMeasurement_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_Bitstring : Operation<(IQArray<Qubit>,IQArray<Boolean>), QVoid>, ICallable
    {
        public StatePrep_Bitstring(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_Bitstring";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_Bitstring";
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
            var (qs,bits) = __in__;
#line 213 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            foreach (var i in new Range(0L, (qs.Length - 1L)))
#line hidden
            {
#line 214 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                if (bits[i])
                {
#line 215 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[i]);
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits)
        {
            return __m__.Run<StatePrep_Bitstring, (IQArray<Qubit>,IQArray<Boolean>), QVoid>((qs, bits));
        }
    }

    public partial class StatePrep_TwoBitstringsMeasurement : Operation<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64), QVoid>, ICallable
    {
        public StatePrep_TwoBitstringsMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_TwoBitstringsMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_TwoBitstringsMeasurement";
        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid> StatePrep_Bitstring
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,bits1,bits2,state) = __in__;
#line 222 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var bits = (IQArray<Boolean>)((state == 0L) ? bits1 : bits2);
#line 223 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            StatePrep_Bitstring.Apply((qs, bits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.StatePrep_Bitstring = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>), QVoid>>(typeof(StatePrep_Bitstring));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, IQArray<Boolean> bits1, IQArray<Boolean> bits2, Int64 state)
        {
            return __m__.Run<StatePrep_TwoBitstringsMeasurement, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64), QVoid>((qs, bits1, bits2, state));
        }
    }

    public partial class CheckTwoBitstringsMeasurement : Operation<(IQArray<Boolean>,IQArray<Boolean>), QVoid>, ICallable
    {
        public CheckTwoBitstringsMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CheckTwoBitstringsMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.CheckTwoBitstringsMeasurement";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64), QVoid> StatePrep_TwoBitstringsMeasurement
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64> TwoBitstringsMeasurement
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>), QVoid> Body => (__in__) =>
        {
            var (b1,b2) = __in__;
#line 228 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((b1.Length, 2L, StatePrep_TwoBitstringsMeasurement.Partial(new Func<(IQArray<Qubit>,Int64), (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64)>((__arg1__) => (__arg1__.Item1, b1, b2, __arg1__.Item2))), TwoBitstringsMeasurement.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>((__arg2__) => (__arg2__, b1, b2))), 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_TwoBitstringsMeasurement = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>,Int64), QVoid>>(typeof(StatePrep_TwoBitstringsMeasurement));
            this.TwoBitstringsMeasurement = this.Factory.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), Int64>>(typeof(TwoBitstringsMeasurement));
        }

        public override IApplyData __dataIn((IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Boolean> b1, IQArray<Boolean> b2)
        {
            return __m__.Run<CheckTwoBitstringsMeasurement, (IQArray<Boolean>,IQArray<Boolean>), QVoid>((b1, b2));
        }
    }

    public partial class T107_TwoBitstringsMeasurement_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T107_TwoBitstringsMeasurement_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T107_TwoBitstringsMeasurement_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T107_TwoBitstringsMeasurement_Test";
        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), QVoid> CheckTwoBitstringsMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 233 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            CheckTwoBitstringsMeasurement.Apply((new QArray<Boolean>(false, true), new QArray<Boolean>(true, false)));
#line 234 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            CheckTwoBitstringsMeasurement.Apply((new QArray<Boolean>(true, true, false), new QArray<Boolean>(false, true, true)));
#line 235 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            CheckTwoBitstringsMeasurement.Apply((new QArray<Boolean>(false, true, true, false), new QArray<Boolean>(false, true, true, true)));
#line 236 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            CheckTwoBitstringsMeasurement.Apply((new QArray<Boolean>(true, false, false, false), new QArray<Boolean>(true, false, true, true)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.CheckTwoBitstringsMeasurement = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), QVoid>>(typeof(CheckTwoBitstringsMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T107_TwoBitstringsMeasurement_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class WState_Arbitrary_Reference : Unitary<IQArray<Qubit>>, ICallable
    {
        public WState_Arbitrary_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "WState_Arbitrary_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.WState_Arbitrary_Reference";
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
#line 243 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var N = qs.Length;
#line 245 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((N == 1L))
            {
#line 247 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }
            else
            {
#line 252 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line 253 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * theta), qs[0L]));
#line 256 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 257 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 258 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
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

    public partial class StatePrep_AllZerosOrWState : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_AllZerosOrWState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_AllZerosOrWState";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_AllZerosOrWState";
        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 265 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 1L))
            {
#line 267 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                WState_Arbitrary_Reference.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_AllZerosOrWState, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T108_AllZerosOrWState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T108_AllZerosOrWState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T108_AllZerosOrWState_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T108_AllZerosOrWState_Test";
        protected ICallable<IQArray<Qubit>, Int64> AllZerosOrWState
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_AllZerosOrWState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 274 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            foreach (var i in new Range(2L, 6L))
#line hidden
            {
#line 275 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                DistinguishStates_MultiQubit.Apply((i, 2L, StatePrep_AllZerosOrWState, AllZerosOrWState, 0L));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AllZerosOrWState = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(AllZerosOrWState));
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_AllZerosOrWState = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_AllZerosOrWState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T108_AllZerosOrWState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class GHZ_State_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public GHZ_State_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZ_State_Reference";
        String ICallable.FullName => "Quantum.Kata.Measurements.GHZ_State_Reference";
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

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 284 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 285 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            foreach (var i in new Range(1L, (qs.Length - 1L)))
#line hidden
            {
#line 286 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (qs.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[i]));
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

    public partial class StatePrep_GHZOrWState : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_GHZOrWState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_GHZOrWState";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_GHZOrWState";
        protected IAdjointable<IQArray<Qubit>> GHZ_State_Reference
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> WState_Arbitrary_Reference
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 293 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 0L))
            {
#line 295 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                GHZ_State_Reference.Apply(qs);
            }
            else
            {
#line 298 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                WState_Arbitrary_Reference.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.GHZ_State_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(GHZ_State_Reference));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_GHZOrWState, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T109_GHZOrWState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T109_GHZOrWState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T109_GHZOrWState_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T109_GHZOrWState_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> GHZOrWState
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_GHZOrWState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 304 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            foreach (var i in new Range(2L, 6L))
#line hidden
            {
#line 305 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                DistinguishStates_MultiQubit.Apply((i, 2L, StatePrep_GHZOrWState, GHZOrWState, 0L));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.GHZOrWState = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(GHZOrWState));
            this.StatePrep_GHZOrWState = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_GHZOrWState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T109_GHZOrWState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_BellState : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_BellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_BellState";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_BellState";
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
            var (qs,state) = __in__;
#line 316 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 317 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 320 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if (((state % 2L) == 1L))
            {
#line 322 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicZ.Apply(qs[1L]);
            }

#line 324 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if (((state / 2L) == 1L))
            {
#line 325 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_BellState, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T110_BellState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T110_BellState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T110_BellState_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T110_BellState_Test";
        protected ICallable<IQArray<Qubit>, Int64> BellState
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 331 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 4L, StatePrep_BellState, BellState, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellState = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(BellState));
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_BellState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T110_BellState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_TwoQubitState : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_TwoQubitState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_TwoQubitState";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_TwoQubitState";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_BasisStateMeasurement
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 342 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            StatePrep_BasisStateMeasurement.Apply((qs, state));
#line 343 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 344 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.StatePrep_BasisStateMeasurement = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_BasisStateMeasurement));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_TwoQubitState, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T111_TwoQubitState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T111_TwoQubitState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T111_TwoQubitState_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T111_TwoQubitState_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_TwoQubitState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> TwoQubitState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 349 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 4L, StatePrep_TwoQubitState, TwoQubitState, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_TwoQubitState = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_TwoQubitState));
            this.TwoQubitState = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(TwoQubitState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T111_TwoQubitState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_TwoQubitStatePartTwo : Operation<(IQArray<Qubit>,Int64), QVoid>, ICallable
    {
        public StatePrep_TwoQubitStatePartTwo(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_TwoQubitStatePartTwo";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_TwoQubitStatePartTwo";
        protected ICallable MicrosoftQuantumCanonApplyToEach
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

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_BasisStateMeasurement
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 361 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            StatePrep_BasisStateMeasurement.Apply((qs, state));
#line 364 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line 365 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line 366 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line 367 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, qs));
#line 368 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line 369 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line 370 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicX, qs));
#line 371 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicSWAP.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.StatePrep_BasisStateMeasurement = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_BasisStateMeasurement));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_TwoQubitStatePartTwo, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T112_TwoQubitStatePartTwo_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T112_TwoQubitStatePartTwo_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T112_TwoQubitStatePartTwo_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T112_TwoQubitStatePartTwo_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,Int64), QVoid> StatePrep_TwoQubitStatePartTwo
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> TwoQubitStatePartTwo
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 376 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 4L, StatePrep_TwoQubitStatePartTwo, TwoQubitStatePartTwo, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_TwoQubitStatePartTwo = this.Factory.Get<ICallable<(IQArray<Qubit>,Int64), QVoid>>(typeof(StatePrep_TwoQubitStatePartTwo));
            this.TwoQubitStatePartTwo = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(TwoQubitStatePartTwo));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T112_TwoQubitStatePartTwo_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_ThreeQubitMeasurement : Adjointable<(IQArray<Qubit>,Int64)>, ICallable
    {
        public StatePrep_ThreeQubitMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_ThreeQubitMeasurement";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_ThreeQubitMeasurement";
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

        public override Func<(IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (qs,state) = __in__;
#line 385 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            WState_Arbitrary_Reference.Apply(qs);
#line 387 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 0L))
            {
#line 389 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply((((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
#line 390 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply((((4D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
            }
            else
            {
#line 393 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply((((4D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
#line 394 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply((((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,state) = __in__;
#line hidden
            if ((state == 0L))
            {
#line hidden
                MicrosoftQuantumIntrinsicR1.Adjoint.Apply((((4D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
#line hidden
                MicrosoftQuantumIntrinsicR1.Adjoint.Apply((((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
            }
            else
            {
#line hidden
                MicrosoftQuantumIntrinsicR1.Adjoint.Apply((((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[2L]));
#line hidden
                MicrosoftQuantumIntrinsicR1.Adjoint.Apply((((4D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D), qs[1L]));
            }

#line hidden
            WState_Arbitrary_Reference.Adjoint.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.WState_Arbitrary_Reference = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(WState_Arbitrary_Reference));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state)
        {
            return __m__.Run<StatePrep_ThreeQubitMeasurement, (IQArray<Qubit>,Int64), QVoid>((qs, state));
        }
    }

    public partial class T113_ThreeQubitMeasurement_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T113_ThreeQubitMeasurement_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T113_ThreeQubitMeasurement_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T113_ThreeQubitMeasurement_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64)> StatePrep_ThreeQubitMeasurement
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> ThreeQubitMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 399 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((3L, 2L, StatePrep_ThreeQubitMeasurement, ThreeQubitMeasurement, 0L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable,Int64), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_ThreeQubitMeasurement = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64)>>(typeof(StatePrep_ThreeQubitMeasurement));
            this.ThreeQubitMeasurement = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(ThreeQubitMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T113_ThreeQubitMeasurement_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_IsQubitZeroOrPlus : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_IsQubitZeroOrPlus(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
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

        String ICallable.Name => "StatePrep_IsQubitZeroOrPlus";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_IsQubitZeroOrPlus";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<(Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q,state) = __in__;
#line 409 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state != 0L))
            {
#line 411 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicH.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Int64 state)
        {
            return __m__.Run<StatePrep_IsQubitZeroOrPlus, (Qubit,Int64), QVoid>((q, state));
        }
    }

    public partial class DistinguishStates_MultiQubit_Threshold : Operation<(Int64,Int64,Double,ICallable,ICallable), QVoid>, ICallable
    {
        public DistinguishStates_MultiQubit_Threshold(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Double,ICallable,ICallable)>, IApplyData
        {
            public In((Int64,Int64,Double,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "DistinguishStates_MultiQubit_Threshold";
        String ICallable.FullName => "Quantum.Kata.Measurements.DistinguishStates_MultiQubit_Threshold";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Double,ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (Nqubit,Nstate,threshold,statePrep,testImpl) = __in__;
#line 419 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nTotal = 1000L;
#line 420 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nOk = 0L;
#line hidden
            {
#line 422 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(Nqubit);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 423 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 425 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomInt.Apply(Nstate);
#line 428 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        statePrep.Apply((qs[0L], state));
#line 431 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var ans = testImpl.Apply<Boolean>(qs[0L]);
#line 432 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((ans == (state == 0L)))
                        {
#line 433 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nOk = (nOk + 1L);
                        }

#line 437 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qs);
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
                    Release.Apply(qs);
                }
            }

#line 441 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((MicrosoftQuantumConvertIntAsDouble.Apply(nOk) < (threshold * MicrosoftQuantumConvertIntAsDouble.Apply(nTotal))))
            {
#line 442 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                throw new ExecutionFailException(String.Format("{0} test runs out of {1} returned incorrect state which does not meet the required threshold of at least {2}%.", (nTotal - nOk), nTotal, (threshold * 100D)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn((Int64,Int64,Double,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 Nqubit, Int64 Nstate, Double threshold, ICallable statePrep, ICallable testImpl)
        {
            return __m__.Run<DistinguishStates_MultiQubit_Threshold, (Int64,Int64,Double,ICallable,ICallable), QVoid>((Nqubit, Nstate, threshold, statePrep, testImpl));
        }
    }

    public partial class T201_IsQubitZeroOrPlus_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T201_IsQubitZeroOrPlus_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T201_IsQubitZeroOrPlus_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T201_IsQubitZeroOrPlus_Test";
        protected ICallable<(Int64,Int64,Double,ICallable,ICallable), QVoid> DistinguishStates_MultiQubit_Threshold
        {
            get;
            set;
        }

        protected ICallable<Qubit, Boolean> IsQubitPlusOrZero
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitZeroOrPlus
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 448 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            DistinguishStates_MultiQubit_Threshold.Apply((1L, 2L, 0.8D, StatePrep_IsQubitZeroOrPlus, IsQubitPlusOrZero));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit_Threshold = this.Factory.Get<ICallable<(Int64,Int64,Double,ICallable,ICallable), QVoid>>(typeof(DistinguishStates_MultiQubit_Threshold));
            this.IsQubitPlusOrZero = this.Factory.Get<ICallable<Qubit, Boolean>>(typeof(IsQubitPlusOrZero));
            this.StatePrep_IsQubitZeroOrPlus = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitZeroOrPlus));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T201_IsQubitZeroOrPlus_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class USD_DistinguishStates_MultiQubit_Threshold : Operation<(Int64,Int64,Double,Double,ICallable,ICallable), QVoid>, ICallable
    {
        public USD_DistinguishStates_MultiQubit_Threshold(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Double,Double,ICallable,ICallable)>, IApplyData
        {
            public In((Int64,Int64,Double,Double,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item5)?.Qubits, ((IApplyData)Data.Item6)?.Qubits);
        }

        String ICallable.Name => "USD_DistinguishStates_MultiQubit_Threshold";
        String ICallable.FullName => "Quantum.Kata.Measurements.USD_DistinguishStates_MultiQubit_Threshold";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Double,Double,ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (Nqubit,Nstate,thresholdInconcl,thresholdConcl,statePrep,testImpl) = __in__;
#line 458 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nTotal = 10000L;
#line 461 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nInconc = 0L;
#line 464 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nConclOne = 0L;
#line 467 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nConclPlus = 0L;
#line hidden
            {
#line 469 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(Nqubit);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 470 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 473 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomInt.Apply(Nstate);
#line 476 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        statePrep.Apply((qs[0L], state));
#line 479 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var ans = testImpl.Apply<Int64>(qs[0L]);
#line 482 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if (((ans < -(1L)) || (ans > 1L)))
                        {
#line 483 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            throw new ExecutionFailException(String.Format("state {0} led to invalid response {1}.", state, ans));
                        }

#line 487 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((ans == -(1L)))
                        {
#line 488 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nInconc = (nInconc + 1L);
                        }

#line 491 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if (((ans == 0L) && (state == 0L)))
                        {
#line 492 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nConclOne = (nConclOne + 1L);
                        }

#line 495 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if (((ans == 1L) && (state == 1L)))
                        {
#line 496 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            nConclPlus = (nConclPlus + 1L);
                        }

#line 500 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((((ans == 0L) && (state == 1L)) || ((ans == 1L) && (state == 0L))))
                        {
#line 501 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            throw new ExecutionFailException(String.Format("state {0} led to incorrect conclusive response {1}.", state, ans));
                        }

#line 505 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qs);
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
                    Release.Apply(qs);
                }
            }

#line 509 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((MicrosoftQuantumConvertIntAsDouble.Apply(nInconc) > (thresholdInconcl * MicrosoftQuantumConvertIntAsDouble.Apply(nTotal))))
            {
#line 510 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                throw new ExecutionFailException(String.Format("{0} test runs out of {1} returned inconclusive which does not meet the required threshold of at most {2}%.", nInconc, nTotal, (thresholdInconcl * 100D)));
            }

#line 513 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((MicrosoftQuantumConvertIntAsDouble.Apply(nConclOne) < (thresholdConcl * MicrosoftQuantumConvertIntAsDouble.Apply(nTotal))))
            {
#line 514 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                throw new ExecutionFailException(String.Format("Only {0} test runs out of {1} returned conclusive |0⟩ which does not meet the required threshold of at least {2}%.", nConclOne, nTotal, (thresholdConcl * 100D)));
            }

#line 517 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((MicrosoftQuantumConvertIntAsDouble.Apply(nConclPlus) < (thresholdConcl * MicrosoftQuantumConvertIntAsDouble.Apply(nTotal))))
            {
#line 518 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                throw new ExecutionFailException(String.Format("Only {0} test runs out of {1} returned conclusive |+> which does not meet the required threshold of at least {2}%.", nConclPlus, nTotal, (thresholdConcl * 100D)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn((Int64,Int64,Double,Double,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 Nqubit, Int64 Nstate, Double thresholdInconcl, Double thresholdConcl, ICallable statePrep, ICallable testImpl)
        {
            return __m__.Run<USD_DistinguishStates_MultiQubit_Threshold, (Int64,Int64,Double,Double,ICallable,ICallable), QVoid>((Nqubit, Nstate, thresholdInconcl, thresholdConcl, statePrep, testImpl));
        }
    }

    public partial class T202_IsQubitZeroOrPlusSimpleUSD_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T202_IsQubitZeroOrPlusSimpleUSD_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T202_IsQubitZeroOrPlusSimpleUSD_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T202_IsQubitZeroOrPlusSimpleUSD_Test";
        protected ICallable<Qubit, Int64> IsQubitPlusZeroOrInconclusiveSimpleUSD
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitZeroOrPlus
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Double,Double,ICallable,ICallable), QVoid> USD_DistinguishStates_MultiQubit_Threshold
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 524 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            USD_DistinguishStates_MultiQubit_Threshold.Apply((1L, 2L, 0.8D, 0.1D, StatePrep_IsQubitZeroOrPlus, IsQubitPlusZeroOrInconclusiveSimpleUSD));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.IsQubitPlusZeroOrInconclusiveSimpleUSD = this.Factory.Get<ICallable<Qubit, Int64>>(typeof(IsQubitPlusZeroOrInconclusiveSimpleUSD));
            this.StatePrep_IsQubitZeroOrPlus = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitZeroOrPlus));
            this.USD_DistinguishStates_MultiQubit_Threshold = this.Factory.Get<ICallable<(Int64,Int64,Double,Double,ICallable,ICallable), QVoid>>(typeof(USD_DistinguishStates_MultiQubit_Threshold));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T202_IsQubitZeroOrPlusSimpleUSD_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_IsQubitNotInABC : Operation<(Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_IsQubitNotInABC(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Int64) data) : base(data)
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

        String ICallable.Name => "StatePrep_IsQubitNotInABC";
        String ICallable.FullName => "Quantum.Kata.Measurements.StatePrep_IsQubitNotInABC";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
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

        public override Func<(Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q,state) = __in__;
#line 530 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var alpha = ((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 3D);
#line 531 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(q);
#line 533 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            if ((state == 0L))
            {
            }
            else if ((state == 1L))
            {
#line 538 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply((alpha, q));
            }
            else
            {
#line 542 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                MicrosoftQuantumIntrinsicR1.Apply(((2D * alpha), q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.R1));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn((Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q, Int64 state)
        {
            return __m__.Run<StatePrep_IsQubitNotInABC, (Qubit,Int64), QVoid>((q, state));
        }
    }

    public partial class ABC_DistinguishStates_MultiQubit_Threshold : Operation<(Int64,Int64,ICallable,ICallable), QVoid>, ICallable
    {
        public ABC_DistinguishStates_MultiQubit_Threshold(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,ICallable,ICallable)>, IApplyData
        {
            public In((Int64,Int64,ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ABC_DistinguishStates_MultiQubit_Threshold";
        String ICallable.FullName => "Quantum.Kata.Measurements.ABC_DistinguishStates_MultiQubit_Threshold";
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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (Nqubit,Nstate,statePrep,testImpl) = __in__;
#line 553 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            var nTotal = 1000L;
#line hidden
            {
#line 555 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                var qs = Allocate.Apply(Nqubit);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 557 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 559 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomInt.Apply(Nstate);
#line 562 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        statePrep.Apply((qs[0L], state));
#line 565 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        var ans = testImpl.Apply<Int64>(qs[0L]);
#line 568 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if (((ans < 0L) || (ans > 2L)))
                        {
#line 569 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            throw new ExecutionFailException("You can not return any value other than 0, 1 or 2.");
                        }

#line 573 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        if ((ans == state))
                        {
#line 574 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                            throw new ExecutionFailException(String.Format("State {0} led to incorrect conclusive response {1}.", state, ans));
                        }

#line 578 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicResetAll.Apply(qs);
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
                    Release.Apply(qs);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn((Int64,Int64,ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 Nqubit, Int64 Nstate, ICallable statePrep, ICallable testImpl)
        {
            return __m__.Run<ABC_DistinguishStates_MultiQubit_Threshold, (Int64,Int64,ICallable,ICallable), QVoid>((Nqubit, Nstate, statePrep, testImpl));
        }
    }

    public partial class T203_IsQubitNotInABC_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T203_IsQubitNotInABC_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T203_IsQubitNotInABC_Test";
        String ICallable.FullName => "Quantum.Kata.Measurements.T203_IsQubitNotInABC_Test";
        protected ICallable<(Int64,Int64,ICallable,ICallable), QVoid> ABC_DistinguishStates_MultiQubit_Threshold
        {
            get;
            set;
        }

        protected ICallable<Qubit, Int64> IsQubitNotInABC
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Int64), QVoid> StatePrep_IsQubitNotInABC
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 584 "G:\\量子实习\\quantumKatas-VS\\Measurements\\Tests.qs"
            ABC_DistinguishStates_MultiQubit_Threshold.Apply((1L, 3L, StatePrep_IsQubitNotInABC, IsQubitNotInABC));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ABC_DistinguishStates_MultiQubit_Threshold = this.Factory.Get<ICallable<(Int64,Int64,ICallable,ICallable), QVoid>>(typeof(ABC_DistinguishStates_MultiQubit_Threshold));
            this.IsQubitNotInABC = this.Factory.Get<ICallable<Qubit, Int64>>(typeof(IsQubitNotInABC));
            this.StatePrep_IsQubitNotInABC = this.Factory.Get<ICallable<(Qubit,Int64), QVoid>>(typeof(StatePrep_IsQubitNotInABC));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T203_IsQubitNotInABC_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}