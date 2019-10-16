#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"AssertEqualOnZeroState1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"AssertEqualOnZeroState1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T11_Eigenstates_ZST_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T11_Eigenstates_ZST_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ArrayWrapperOperation1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ArrayWrapperOperation1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ArrayWrapperOperation1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.PhaseEstimation.ArrayWrapperOperation1\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ArrayWrapperOperation1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.PhaseEstimation.ArrayWrapperOperation1\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ArrayWrapperOperation1\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.PhaseEstimation.ArrayWrapperOperation1\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T12_UnitaryPower_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T12_UnitaryPower_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"TestAssertIsEigenstate_True\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"TestAssertIsEigenstate_True\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T14_QPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T14_QPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":71,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Test1BitPEOnOnePair\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expected\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":93},\"Item2\":{\"Line\":1,\"Column\":101}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Test1BitPEOnOnePair\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T21_SingleBitPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T21_SingleBitPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":101,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Test2BitPEOnOnePair\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expected\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":93},\"Item2\":{\"Line\":1,\"Column\":101}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Test2BitPEOnOnePair\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T22_TwoBitPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":120,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"T22_TwoBitPE_Test\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":120,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetOracleCallsCount\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetOracleCallsCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ResetOracleCallsCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"GetMaxQubitCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":139,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":141,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"ResetQubitCount\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/Tests.qs\",\"Position\":{\"Item1\":141,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.PhaseEstimation
{
    public partial class AssertEqualOnZeroState1 : Operation<(ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertEqualOnZeroState1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IAdjointable)>, IApplyData
        {
            public In((ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AssertEqualOnZeroState1";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.AssertEqualOnZeroState1";
        protected ICallable<(Result,Qubit), QVoid> MicrosoftQuantumDiagnosticsAssertQubit
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

        public override Func<(ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (testImpl,refImpl) = __in__;
#line hidden
            {
#line 22 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 24 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                    testImpl.Apply(q);
#line 27 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                    refImpl.Adjoint.Apply(q);
#line 29 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertQubit.Apply((Result.Zero, q));
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
            this.MicrosoftQuantumDiagnosticsAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
        }

        public override IApplyData __dataIn((ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable testImpl, IAdjointable refImpl)
        {
            return __m__.Run<AssertEqualOnZeroState1, (ICallable,IAdjointable), QVoid>((testImpl, refImpl));
        }
    }

    public partial class T11_Eigenstates_ZST_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_Eigenstates_ZST_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_Eigenstates_ZST_Test";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.T11_Eigenstates_ZST_Test";
        protected ICallable<(ICallable,IAdjointable), QVoid> AssertEqualOnZeroState1
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Int64)> Eigenstates_ZST
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Int64)> Eigenstates_ZST_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 35 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            foreach (var state in new Range(0L, 1L))
#line hidden
            {
#line 36 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                AssertEqualOnZeroState1.Apply((Eigenstates_ZST.Partial(new Func<Qubit, (Qubit,Int64)>((__arg1__) => (__arg1__, state))), Eigenstates_ZST_Reference.Partial(new Func<Qubit, (Qubit,Int64)>((__arg2__) => (__arg2__, state)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState1 = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState1));
            this.Eigenstates_ZST = this.Factory.Get<IAdjointable<(Qubit,Int64)>>(typeof(Eigenstates_ZST));
            this.Eigenstates_ZST_Reference = this.Factory.Get<IAdjointable<(Qubit,Int64)>>(typeof(Eigenstates_ZST_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_Eigenstates_ZST_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class ArrayWrapperOperation1 : Unitary<(IUnitary,IQArray<Qubit>)>, ICallable
    {
        public ArrayWrapperOperation1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IQArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ArrayWrapperOperation1";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.ArrayWrapperOperation1";
        public override Func<(IUnitary,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 45 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
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
            return __m__.Run<ArrayWrapperOperation1, (IUnitary,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class T12_UnitaryPower_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_UnitaryPower_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_UnitaryPower_Test";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.T12_UnitaryPower_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ArrayWrapperOperation1
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,Int64), IUnitary> UnitaryPower
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,Int64), IUnitary> UnitaryPower_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 50 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            foreach (var U in new QArray<IUnitary>(MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicT))
#line hidden
            {
#line 51 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                foreach (var power in new Range(1L, 5L))
#line hidden
                {
#line 52 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((1L, ArrayWrapperOperation1.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (UnitaryPower.Apply((U, power)), __arg1__))), ArrayWrapperOperation1.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (UnitaryPower_Reference.Apply((U, power)), __arg2__)))));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.ArrayWrapperOperation1 = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ArrayWrapperOperation1));
            this.UnitaryPower = this.Factory.Get<ICallable<(IUnitary,Int64), IUnitary>>(typeof(UnitaryPower));
            this.UnitaryPower_Reference = this.Factory.Get<ICallable<(IUnitary,Int64), IUnitary>>(typeof(UnitaryPower_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_UnitaryPower_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class TestAssertIsEigenstate_True : Operation<QVoid, QVoid>, ICallable
    {
        public TestAssertIsEigenstate_True(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestAssertIsEigenstate_True";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.TestAssertIsEigenstate_True";
        protected ICallable MicrosoftQuantumCanonBoundCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IAdjointable), QVoid> AssertIsEigenstate
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 62 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            foreach (var (unitary,statePrep) in new QArray<(IUnitary,IUnitary)>((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicI), (MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicX), (MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicI), (MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicX), (MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH), (MicrosoftQuantumIntrinsicX, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH))), (MicrosoftQuantumIntrinsicY, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicS))), (MicrosoftQuantumIntrinsicY, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicS)))))
#line hidden
            {
#line 66 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
                AssertIsEigenstate.Apply((unitary, statePrep));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBoundCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BoundCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Y));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.AssertIsEigenstate = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertIsEigenstate));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestAssertIsEigenstate_True, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_QPE_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_QPE_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_QPE_Test";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.T14_QPE_Test";
        protected ICallable<(Double,Double,Double), QVoid> MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
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

        protected ICallable<(IUnitary,IAdjointable,Int64), Double> QPE
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 73 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicI, 1L)), 0D, 0.25D));
#line 74 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicX, 1L)), 0.5D, 0.25D));
#line 76 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicI, 2L)), 0D, 0.125D));
#line 77 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicX, 2L)), 0.25D, 0.125D));
#line 79 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicT, MicrosoftQuantumIntrinsicI, 3L)), 0D, 0.0625D));
#line 80 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((QPE.Apply((MicrosoftQuantumIntrinsicT, MicrosoftQuantumIntrinsicX, 3L)), 0.125D, 0.0625D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityWithinToleranceFact));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.QPE = this.Factory.Get<ICallable<(IUnitary,IAdjointable,Int64), Double>>(typeof(QPE));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_QPE_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Test1BitPEOnOnePair : Operation<(IUnitary,IAdjointable,Int64), QVoid>, ICallable
    {
        public Test1BitPEOnOnePair(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IAdjointable,Int64)>, IApplyData
        {
            public In((IUnitary,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Test1BitPEOnOnePair";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.Test1BitPEOnOnePair";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Int64> GetMaxQubitCount
        {
            get;
            set;
        }

        protected ICallable GetOracleCallsCount
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> ResetOracleCallsCount
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> ResetQubitCount
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,IAdjointable), Int64> SingleBitPE
        {
            get;
            set;
        }

        public override Func<(IUnitary,IAdjointable,Int64), QVoid> Body => (__in__) =>
        {
            var (U,P,expected) = __in__;
#line 89 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            ResetQubitCount.Apply(QVoid.Instance);
#line 90 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            ResetOracleCallsCount.Apply(QVoid.Instance);
#line 92 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            var actual = SingleBitPE.Apply((U, P));
#line 93 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((actual, expected, String.Format("Unexpected return for ({0}, {1}): expected {2}, got {3}", U, P, expected, actual)));
#line 95 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            var nq = GetMaxQubitCount.Apply(QVoid.Instance);
#line 96 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nq, 2L, String.Format("You are allowed to allocate exactly 2 qubits, and you allocated {0}", nq)));
#line 98 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            var nu = GetOracleCallsCount.Apply<Int64>(U.Controlled);
#line 99 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nu, 1L, String.Format("You are allowed to call Controlled U exactly once, and you called it {0} times", nu)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.GetMaxQubitCount = this.Factory.Get<ICallable<QVoid, Int64>>(typeof(GetMaxQubitCount));
            this.GetOracleCallsCount = this.Factory.Get<ICallable>(typeof(GetOracleCallsCount<>));
            this.ResetOracleCallsCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(ResetOracleCallsCount));
            this.ResetQubitCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(ResetQubitCount));
            this.SingleBitPE = this.Factory.Get<ICallable<(IUnitary,IAdjointable), Int64>>(typeof(SingleBitPE));
        }

        public override IApplyData __dataIn((IUnitary,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary U, IAdjointable P, Int64 expected)
        {
            return __m__.Run<Test1BitPEOnOnePair, (IUnitary,IAdjointable,Int64), QVoid>((U, P, expected));
        }
    }

    public partial class T21_SingleBitPE_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_SingleBitPE_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_SingleBitPE_Test";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.T21_SingleBitPE_Test";
        protected ICallable MicrosoftQuantumCanonBoundCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicZ
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,IAdjointable,Int64), QVoid> Test1BitPEOnOnePair
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 103 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test1BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicI, 1L));
#line 104 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test1BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicX, -(1L)));
#line 105 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test1BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, 1L));
#line 106 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test1BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicX, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH)), -(1L)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBoundCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BoundCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.Test1BitPEOnOnePair = this.Factory.Get<ICallable<(IUnitary,IAdjointable,Int64), QVoid>>(typeof(Test1BitPEOnOnePair));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_SingleBitPE_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Test2BitPEOnOnePair : Operation<(IUnitary,IAdjointable,Double), QVoid>, ICallable
    {
        public Test2BitPEOnOnePair(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IAdjointable,Double)>, IApplyData
        {
            public In((IUnitary,IAdjointable,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Test2BitPEOnOnePair";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.Test2BitPEOnOnePair";
        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected ICallable<(Double,Double,Double), QVoid> MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact
        {
            get;
            set;
        }

        protected ICallable<QVoid, Int64> GetMaxQubitCount
        {
            get;
            set;
        }

        protected ICallable<QVoid, QVoid> ResetQubitCount
        {
            get;
            set;
        }

        protected ICallable<(IUnitary,IAdjointable), Double> TwoBitPE
        {
            get;
            set;
        }

        public override Func<(IUnitary,IAdjointable,Double), QVoid> Body => (__in__) =>
        {
            var (U,P,expected) = __in__;
#line 112 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            ResetQubitCount.Apply(QVoid.Instance);
#line 114 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            var actual = TwoBitPE.Apply((U, P));
#line 115 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((actual, expected, 0.001D));
#line 117 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            var nq = GetMaxQubitCount.Apply(QVoid.Instance);
#line 118 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nq, 2L, String.Format("You are allowed to allocate exactly 2 qubits, and you allocated {0}", nq)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityWithinToleranceFact));
            this.GetMaxQubitCount = this.Factory.Get<ICallable<QVoid, Int64>>(typeof(GetMaxQubitCount));
            this.ResetQubitCount = this.Factory.Get<ICallable<QVoid, QVoid>>(typeof(ResetQubitCount));
            this.TwoBitPE = this.Factory.Get<ICallable<(IUnitary,IAdjointable), Double>>(typeof(TwoBitPE));
        }

        public override IApplyData __dataIn((IUnitary,IAdjointable,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary U, IAdjointable P, Double expected)
        {
            return __m__.Run<Test2BitPEOnOnePair, (IUnitary,IAdjointable,Double), QVoid>((U, P, expected));
        }
    }

    public partial class T22_TwoBitPE_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_TwoBitPE_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_TwoBitPE_Test";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.T22_TwoBitPE_Test";
        protected ICallable MicrosoftQuantumCanonBoundCA
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
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

        protected ICallable<(IUnitary,IAdjointable,Double), QVoid> Test2BitPEOnOnePair
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 122 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicI, 0D));
#line 123 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicX, 0.5D));
#line 124 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicX, 0.25D));
#line 125 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicZ)), MicrosoftQuantumIntrinsicX, 0.75D));
#line 127 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, 0D));
#line 128 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumIntrinsicX, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH)), 0.5D));
#line 129 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicH)), MicrosoftQuantumIntrinsicH, 0D));
#line 130 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicH)), MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH)), 0.25D));
#line 131 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            Test2BitPEOnOnePair.Apply((MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicS, MicrosoftQuantumIntrinsicZ, MicrosoftQuantumIntrinsicH)), MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH)), 0.75D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBoundCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BoundCA<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.Test2BitPEOnOnePair = this.Factory.Get<ICallable<(IUnitary,IAdjointable,Double), QVoid>>(typeof(Test2BitPEOnOnePair));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_TwoBitPE_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class GetOracleCallsCount<__T__> : Function<__T__, Int64>, ICallable
    {
        public GetOracleCallsCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetOracleCallsCount";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.GetOracleCallsCount";
        public override Func<__T__, Int64> Body => (__in__) =>
        {
            var oracle = __in__;
#line 136 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(__T__ data) => new QTuple<__T__>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, __T__ oracle)
        {
            return __m__.Run<GetOracleCallsCount<__T__>, __T__, Int64>(oracle);
        }
    }

    public partial class ResetOracleCallsCount : Function<QVoid, QVoid>, ICallable
    {
        public ResetOracleCallsCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResetOracleCallsCount";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.ResetOracleCallsCount";
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
            return __m__.Run<ResetOracleCallsCount, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class GetMaxQubitCount : Function<QVoid, Int64>, ICallable
    {
        public GetMaxQubitCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetMaxQubitCount";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.GetMaxQubitCount";
        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 140 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\Tests.qs"
            return 0L;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<GetMaxQubitCount, QVoid, Int64>(QVoid.Instance);
        }
    }

    public partial class ResetQubitCount : Function<QVoid, QVoid>, ICallable
    {
        public ResetQubitCount(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ResetQubitCount";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.ResetQubitCount";
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
            return __m__.Run<ResetQubitCount, QVoid, QVoid>(QVoid.Instance);
        }
    }
}