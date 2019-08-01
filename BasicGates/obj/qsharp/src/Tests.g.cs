#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":98}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.BasicGates.ArrayWrapperOperation\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":98}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.BasicGates.ArrayWrapperOperation\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"ArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":98}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.BasicGates.ArrayWrapperOperation\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T11_StateFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T11_StateFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T12_BasisChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T12_BasisChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T13_SignFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T13_SignFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T14_AmplitudeChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T14_AmplitudeChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T15_PhaseFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T15_PhaseFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T16_PhaseChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T16_PhaseChange_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":76}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.BasicGates.StatePrep_BellState\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":76}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.BasicGates.StatePrep_BellState\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":76}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.BasicGates.StatePrep_BellState\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"VerifyBellStateConversion\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"startState\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":77},\"Item2\":{\"Line\":1,\"Column\":87}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"targetState\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":95},\"Item2\":{\"Line\":1,\"Column\":106}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"VerifyBellStateConversion\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T17_BellStateChange1_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T17_BellStateChange1_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T18_BellStateChange2_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T18_BellStateChange2_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T19_BellStateChange3_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T19_BellStateChange3_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":64}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.BasicGates.StatePrep_A\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T21_TwoQubitGate1_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":149,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T21_TwoQubitGate1_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":149,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"StatePrep_PlusPlus\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":176,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":58}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.BasicGates.StatePrep_PlusPlus\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T22_TwoQubitGate2_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T22_TwoQubitGate2_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":201,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":201,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"SwapWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":201,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.BasicGates.SwapWrapper\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T23_TwoQubitGate3_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":206,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T23_TwoQubitGate3_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":206,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T24_ToffoliGate_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":213,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T24_ToffoliGate_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":213,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T25_FredkinGate_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.BasicGates\",\"Name\":\"T25_FredkinGate_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/BasicGates/Tests.qs\",\"Position\":{\"Item1\":219,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.BasicGates
{
    public partial class ArrayWrapperOperation : Unitary<(IUnitary,IQArray<Qubit>)>, ICallable
    {
        public ArrayWrapperOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IQArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ArrayWrapperOperation";
        String ICallable.FullName => "Quantum.Kata.BasicGates.ArrayWrapperOperation";
        public override Func<(IUnitary,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 33 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            op.Controlled.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Controlled.Adjoint.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[0L]), qs[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(qs[0L]), qs[1L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IUnitary,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, IQArray<Qubit> qs)
        {
            return __m__.Run<ArrayWrapperOperation, (IUnitary,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class T11_StateFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_StateFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_StateFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T11_StateFlip_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IUnitary<Qubit> StateFlip
        {
            get;
            set;
        }

        protected IUnitary<Qubit> StateFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 39 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (StateFlip, __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (StateFlip_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.StateFlip = this.Factory.Get<IUnitary<Qubit>>(typeof(StateFlip));
            this.StateFlip_Reference = this.Factory.Get<IUnitary<Qubit>>(typeof(StateFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_StateFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_BasisChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_BasisChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_BasisChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T12_BasisChange_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IUnitary<Qubit> BasisChange
        {
            get;
            set;
        }

        protected IUnitary<Qubit> BasisChange_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 45 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (BasisChange, __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (BasisChange_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.BasisChange = this.Factory.Get<IUnitary<Qubit>>(typeof(BasisChange));
            this.BasisChange_Reference = this.Factory.Get<IUnitary<Qubit>>(typeof(BasisChange_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_BasisChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_SignFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_SignFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_SignFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T13_SignFlip_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IUnitary<Qubit> SignFlip
        {
            get;
            set;
        }

        protected IUnitary<Qubit> SignFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 51 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (SignFlip, __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (SignFlip_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.SignFlip = this.Factory.Get<IUnitary<Qubit>>(typeof(SignFlip));
            this.SignFlip_Reference = this.Factory.Get<IUnitary<Qubit>>(typeof(SignFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_SignFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_AmplitudeChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_AmplitudeChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_AmplitudeChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T14_AmplitudeChange_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> AmplitudeChange
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> AmplitudeChange_Reference
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 57 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            foreach (var i in new Range(0L, 36L))
#line hidden
            {
#line 58 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 59 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (AmplitudeChange.Partial(new Func<Qubit, (Double,Qubit)>((__arg2__) => (alpha, __arg2__))), __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg3__) => (AmplitudeChange_Reference.Partial(new Func<Qubit, (Double,Qubit)>((__arg4__) => (alpha, __arg4__))), __arg3__)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.AmplitudeChange = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(AmplitudeChange));
            this.AmplitudeChange_Reference = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(AmplitudeChange_Reference));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_AmplitudeChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T15_PhaseFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T15_PhaseFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T15_PhaseFlip_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T15_PhaseFlip_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IUnitary<Qubit> PhaseFlip
        {
            get;
            set;
        }

        protected IUnitary<Qubit> PhaseFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 66 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (PhaseFlip, __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (PhaseFlip_Reference, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.PhaseFlip = this.Factory.Get<IUnitary<Qubit>>(typeof(PhaseFlip));
            this.PhaseFlip_Reference = this.Factory.Get<IUnitary<Qubit>>(typeof(PhaseFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T15_PhaseFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T16_PhaseChange_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T16_PhaseChange_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T16_PhaseChange_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T16_PhaseChange_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> PhaseChange
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> PhaseChange_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 72 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            foreach (var i in new Range(0L, 36L))
#line hidden
            {
#line 73 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 74 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (PhaseChange.Partial(new Func<Qubit, (Double,Qubit)>((__arg2__) => (alpha, __arg2__))), __arg1__))), ArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg3__) => (PhaseChange_Reference.Partial(new Func<Qubit, (Double,Qubit)>((__arg4__) => (alpha, __arg4__))), __arg3__)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.ArrayWrapperOperation = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation));
            this.PhaseChange = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(PhaseChange));
            this.PhaseChange_Reference = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(PhaseChange_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T16_PhaseChange_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_BellState : Unitary<(IQArray<Qubit>,Int64)>, ICallable
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
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_BellState";
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
#line 86 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 87 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 90 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            if (((state % 2L) == 1L))
            {
#line 92 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                MicrosoftQuantumIntrinsicZ.Apply(qs[1L]);
            }

#line 95 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            if (((state / 2L) == 1L))
            {
#line 96 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,state) = __in__;
#line hidden
            if (((state / 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[1L]);
            }

#line hidden
            if (((state % 2L) == 1L))
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
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(qs,state)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[0L], qs[1L])));
#line hidden
            if (((state % 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicZ.Controlled.Apply((__controlQubits__, qs[1L]));
            }

#line hidden
            if (((state / 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[1L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Int64)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(qs,state)) = __in__;
#line hidden
            if (((state / 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[1L]));
            }

#line hidden
            if (((state % 2L) == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicZ.Adjoint.Controlled.Apply((__controlQubits__, qs[1L]));
            }

#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[0L], qs[1L])));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
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

    public partial class VerifyBellStateConversion : Operation<(IUnitary,Int64,Int64), QVoid>, ICallable
    {
        public VerifyBellStateConversion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,Int64)>, IApplyData
        {
            public In((IUnitary,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "VerifyBellStateConversion";
        String ICallable.FullName => "Quantum.Kata.BasicGates.VerifyBellStateConversion";
        protected ICallable MicrosoftQuantumArraysRest
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

        protected IUnitary<(IQArray<Qubit>,Int64)> StatePrep_BellState
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64,Int64), QVoid> Body => (__in__) =>
        {
            var (testOp,startState,targetState) = __in__;
#line hidden
            {
#line 104 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 105 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 108 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    StatePrep_BellState.Controlled.Apply((new QArray<Qubit>(qs[0L]), (MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs), startState)));
#line 111 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    testOp.Controlled.Apply((new QArray<Qubit>(qs[0L]), MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs)));
#line 114 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    StatePrep_BellState.Adjoint.Controlled.Apply((new QArray<Qubit>(qs[0L]), (MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs), targetState)));
#line 116 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 119 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
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
            this.MicrosoftQuantumArraysRest = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Rest<>));
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.StatePrep_BellState = this.Factory.Get<IUnitary<(IQArray<Qubit>,Int64)>>(typeof(StatePrep_BellState));
        }

        public override IApplyData __dataIn((IUnitary,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary testOp, Int64 startState, Int64 targetState)
        {
            return __m__.Run<VerifyBellStateConversion, (IUnitary,Int64,Int64), QVoid>((testOp, startState, targetState));
        }
    }

    public partial class T17_BellStateChange1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T17_BellStateChange1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T17_BellStateChange1_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T17_BellStateChange1_Test";
        protected IUnitary<IQArray<Qubit>> BellStateChange1
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 126 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange1, 0L, 1L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange1 = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(BellStateChange1));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(IUnitary,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T17_BellStateChange1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T18_BellStateChange2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T18_BellStateChange2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T18_BellStateChange2_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T18_BellStateChange2_Test";
        protected IUnitary<IQArray<Qubit>> BellStateChange2
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 132 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange2, 0L, 2L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange2 = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(BellStateChange2));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(IUnitary,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T18_BellStateChange2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T19_BellStateChange3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T19_BellStateChange3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T19_BellStateChange3_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T19_BellStateChange3_Test";
        protected IUnitary<IQArray<Qubit>> BellStateChange3
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,Int64,Int64), QVoid> VerifyBellStateConversion
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 138 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            VerifyBellStateConversion.Apply((BellStateChange3, 0L, 3L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.BellStateChange3 = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(BellStateChange3));
            this.VerifyBellStateConversion = this.Factory.Get<ICallable<(IUnitary,Int64,Int64), QVoid>>(typeof(VerifyBellStateConversion));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T19_BellStateChange3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_A : Adjointable<(Double,Qubit)>, ICallable
    {
        public StatePrep_A(IOperationFactory m) : base(m)
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

        String ICallable.Name => "StatePrep_A";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_A";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        public override Func<(Double,Qubit), QVoid> Body => (__in__) =>
        {
            var (alpha,q) = __in__;
#line 145 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), q));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Double,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (alpha,q) = __in__;
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

        public override IApplyData __dataIn((Double,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Double alpha, Qubit q)
        {
            return __m__.Run<StatePrep_A, (Double,Qubit), QVoid>((alpha, q));
        }
    }

    public partial class T21_TwoQubitGate1_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_TwoQubitGate1_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_TwoQubitGate1_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T21_TwoQubitGate1_Test";
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

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected IAdjointable<(Double,Qubit)> StatePrep_A
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate1
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate1_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 154 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 155 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    foreach (var i in new Range(0L, 36L))
#line hidden
                    {
#line 156 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                        var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 159 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                        StatePrep_A.Apply((alpha, qs[0L]));
#line 162 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                        TwoQubitGate1.Apply(qs);
#line 165 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                        TwoQubitGate1_Reference.Adjoint.Apply(qs);
#line 166 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                        StatePrep_A.Adjoint.Apply((alpha, qs[0L]));
#line 169 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
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
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.StatePrep_A = this.Factory.Get<IAdjointable<(Double,Qubit)>>(typeof(StatePrep_A));
            this.TwoQubitGate1 = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate1));
            this.TwoQubitGate1_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate1_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_TwoQubitGate1_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_PlusPlus : Adjointable<IQArray<Qubit>>, ICallable
    {
        public StatePrep_PlusPlus(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePrep_PlusPlus";
        String ICallable.FullName => "Quantum.Kata.BasicGates.StatePrep_PlusPlus";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
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
#line 178 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<StatePrep_PlusPlus, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class T22_TwoQubitGate2_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_TwoQubitGate2_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_TwoQubitGate2_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T22_TwoQubitGate2_Test";
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

        protected IAdjointable<IQArray<Qubit>> StatePrep_PlusPlus
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate2
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate2_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 184 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 186 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    StatePrep_PlusPlus.Apply(qs);
#line 189 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    TwoQubitGate2.Apply(qs);
#line 192 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    TwoQubitGate2_Reference.Adjoint.Apply(qs);
#line 193 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
                    StatePrep_PlusPlus.Adjoint.Apply(qs);
#line 196 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
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
            this.StatePrep_PlusPlus = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(StatePrep_PlusPlus));
            this.TwoQubitGate2 = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate2));
            this.TwoQubitGate2_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate2_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_TwoQubitGate2_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class SwapWrapper : Adjointable<IQArray<Qubit>>, ICallable
    {
        public SwapWrapper(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SwapWrapper";
        String ICallable.FullName => "Quantum.Kata.BasicGates.SwapWrapper";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 203 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumIntrinsicSWAP.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumIntrinsicSWAP.Adjoint.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<SwapWrapper, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class T23_TwoQubitGate3_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_TwoQubitGate3_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_TwoQubitGate3_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T23_TwoQubitGate3_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> SwapWrapper
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate3
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> TwoQubitGate3_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 208 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, SwapWrapper, TwoQubitGate3_Reference));
#line 209 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, TwoQubitGate3, TwoQubitGate3_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.SwapWrapper = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(SwapWrapper));
            this.TwoQubitGate3 = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate3));
            this.TwoQubitGate3_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(TwoQubitGate3_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_TwoQubitGate3_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T24_ToffoliGate_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T24_ToffoliGate_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T24_ToffoliGate_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T24_ToffoliGate_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ToffoliGate
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ToffoliGate_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 215 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((3L, ToffoliGate, ToffoliGate_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ToffoliGate = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ToffoliGate));
            this.ToffoliGate_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ToffoliGate_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T24_ToffoliGate_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T25_FredkinGate_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T25_FredkinGate_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T25_FredkinGate_Test";
        String ICallable.FullName => "Quantum.Kata.BasicGates.T25_FredkinGate_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> FredkinGate
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> FredkinGate_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 221 "G:\\量子实习\\quantumKatas-VS\\BasicGates\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((3L, FredkinGate, FredkinGate_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.FredkinGate = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(FredkinGate));
            this.FredkinGate_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(FredkinGate_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T25_FredkinGate_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}