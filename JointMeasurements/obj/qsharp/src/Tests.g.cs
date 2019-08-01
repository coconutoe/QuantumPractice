#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DistinguishStates_MultiQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nqubit\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nstate\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"statePrep\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":78}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":122},\"Item2\":{\"Line\":1,\"Column\":130}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"preserveState\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":151},\"Item2\":{\"Line\":1,\"Column\":164}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"Int\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DistinguishStates_MultiQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_ParityMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_ParityMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_ParityMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":57,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_ParityMeasurement\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T01_SingleQubitMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T01_SingleQubitMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":76,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T02_ParityMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T02_ParityMeasurement_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T03_GHZOrGHZWithX_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T03_GHZOrGHZWithX_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":88,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_WState_Arbitrary\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_WState_Arbitrary\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_WState_Arbitrary\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_WState_Arbitrary\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_WState_Arbitrary\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.JointMeasurements.StatePrep_WState_Arbitrary\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_WState_Arbitrary\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_WState_Arbitrary\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":118,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_GHZOrWState\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T04_GHZOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T04_GHZOrWState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_DifferentBasis\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Double\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_DifferentBasis\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_DifferentBasis\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_DifferentBasis\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T05_DifferentBasis_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T05_DifferentBasis_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":153,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alpha\"]},\"Type\":{\"Case\":\"Double\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Double\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"StatePrep_A\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":160,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.JointMeasurements.StatePrep_A\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T06_ControlledX_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T06_ControlledX_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":167,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"CNOTWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":193,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"CNOTWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":195,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"CNOTWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":199,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T07_ControlledX_General_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":203,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"T07_ControlledX_General_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tests.qs\",\"Position\":{\"Item1\":203,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.JointMeasurements
{
    public partial class DistinguishStates_MultiQubit : Operation<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>, ICallable
    {
        public DistinguishStates_MultiQubit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,IAdjointable,ICallable,Boolean)>, IApplyData
        {
            public In((Int64,Int64,IAdjointable,ICallable,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "DistinguishStates_MultiQubit";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.DistinguishStates_MultiQubit";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumDiagnosticsAssertAllZero
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

        protected ICallable<QVoid, Double> MicrosoftQuantumMathPI
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> MicrosoftQuantumMathRandomReal
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> Body => (__in__) =>
        {
            var (Nqubit,Nstate,statePrep,testImpl,preserveState) = __in__;
#line 22 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            var nTotal = 100L;
#line 23 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            var nOk = 0L;
#line hidden
            {
#line 25 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                var qs = Allocate.Apply(Nqubit);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 26 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                    foreach (var i in new Range(1L, nTotal))
#line hidden
                    {
#line 28 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        var state = MicrosoftQuantumMathRandomInt.Apply(Nstate);
#line 31 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        var alpha = (MicrosoftQuantumMathRandomReal.Apply(5L) * MicrosoftQuantumMathPI.Apply(QVoid.Instance));
#line 34 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        statePrep.Apply((qs, state, alpha));
#line 37 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        var ans = testImpl.Apply<Int64>(qs);
#line 38 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        if ((ans == state))
                        {
#line 39 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                            nOk = (nOk + 1L);
                        }

#line 42 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        if (preserveState)
                        {
#line 44 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                            statePrep.Adjoint.Apply((qs, state, alpha));
#line 45 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                            MicrosoftQuantumDiagnosticsAssertAllZero.Apply(qs);
                        }
                        else
                        {
#line 48 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
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
                    Release.Apply(qs);
                }
            }

#line 53 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((nOk, nTotal, String.Format("{0} test runs out of {1} returned incorrect state.", (nTotal - nOk), nTotal)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.MicrosoftQuantumMathRandomReal = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Math.RandomReal));
        }

        public override IApplyData __dataIn((Int64,Int64,IAdjointable,ICallable,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 Nqubit, Int64 Nstate, IAdjointable statePrep, ICallable testImpl, Boolean preserveState)
        {
            return __m__.Run<DistinguishStates_MultiQubit, (Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>((Nqubit, Nstate, statePrep, testImpl, preserveState));
        }
    }

    public partial class StatePrep_ParityMeasurement : Adjointable<(IQArray<Qubit>,Int64,Double)>, ICallable
    {
        public StatePrep_ParityMeasurement(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_ParityMeasurement";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.StatePrep_ParityMeasurement";
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

        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> Body => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line 62 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), qs[0L]));
#line 63 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            foreach (var i in new Range(1L, (qs.Length - 1L)))
#line hidden
            {
#line 64 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[i]));
            }

#line 67 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            if ((state == 1L))
            {
#line 69 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                foreach (var i in new Range(0L, ((qs.Length / 2L) - 1L)))
#line hidden
                {
#line 70 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(qs[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line hidden
            if ((state == 1L))
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, ((qs.Length / 2L) - 1L))))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[i]);
                }
            }

#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (qs.Length - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[i]));
            }

#line hidden
            MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * alpha), qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state, Double alpha)
        {
            return __m__.Run<StatePrep_ParityMeasurement, (IQArray<Qubit>,Int64,Double), QVoid>((qs, state, alpha));
        }
    }

    public partial class T01_SingleQubitMeasurement_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T01_SingleQubitMeasurement_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T01_SingleQubitMeasurement_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T01_SingleQubitMeasurement_Test";
        protected ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> SingleQubitMeasurement
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_ParityMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 78 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 2L, StatePrep_ParityMeasurement, SingleQubitMeasurement, false));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.SingleQubitMeasurement = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(SingleQubitMeasurement));
            this.StatePrep_ParityMeasurement = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_ParityMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T01_SingleQubitMeasurement_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T02_ParityMeasurement_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T02_ParityMeasurement_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T02_ParityMeasurement_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T02_ParityMeasurement_Test";
        protected ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> ParityMeasurement
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_ParityMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 84 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 2L, StatePrep_ParityMeasurement, ParityMeasurement, true));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.ParityMeasurement = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(ParityMeasurement));
            this.StatePrep_ParityMeasurement = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_ParityMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T02_ParityMeasurement_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T03_GHZOrGHZWithX_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T03_GHZOrGHZWithX_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T03_GHZOrGHZWithX_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T03_GHZOrGHZWithX_Test";
        protected ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> GHZOrGHZWithX
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_ParityMeasurement
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 90 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((4L, 2L, StatePrep_ParityMeasurement, GHZOrGHZWithX, true));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.GHZOrGHZWithX = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(GHZOrGHZWithX));
            this.StatePrep_ParityMeasurement = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_ParityMeasurement));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T03_GHZOrGHZWithX_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_WState_Arbitrary : Unitary<IQArray<Qubit>>, ICallable
    {
        public StatePrep_WState_Arbitrary(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "StatePrep_WState_Arbitrary";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.StatePrep_WState_Arbitrary";
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
#line 98 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            var N = qs.Length;
#line 100 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            if ((N == 1L))
            {
#line 102 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
            }
            else
            {
#line 108 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                var theta = MicrosoftQuantumMathArcSin.Apply((1D / MicrosoftQuantumMathSqrt.Apply(MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line 109 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((2D * theta), qs[0L]));
#line 112 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 113 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                self.Controlled.Apply((qs?.Slice(new Range(0L, 0L)), qs?.Slice(new Range(1L, (N - 1L)))));
#line 114 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
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
            return __m__.Run<StatePrep_WState_Arbitrary, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class StatePrep_GHZOrWState : Adjointable<(IQArray<Qubit>,Int64,Double)>, ICallable
    {
        public StatePrep_GHZOrWState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_GHZOrWState";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.StatePrep_GHZOrWState";
        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_ParityMeasurement
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> StatePrep_WState_Arbitrary
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> Body => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line 122 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            if ((state == 0L))
            {
#line 123 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                StatePrep_ParityMeasurement.Apply((qs, 0L, alpha));
            }
            else
            {
#line 125 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                StatePrep_WState_Arbitrary.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line hidden
            if ((state == 0L))
            {
#line hidden
                StatePrep_ParityMeasurement.Adjoint.Apply((qs, 0L, alpha));
            }
            else
            {
#line hidden
                StatePrep_WState_Arbitrary.Adjoint.Apply(qs);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.StatePrep_ParityMeasurement = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_ParityMeasurement));
            this.StatePrep_WState_Arbitrary = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(StatePrep_WState_Arbitrary));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state, Double alpha)
        {
            return __m__.Run<StatePrep_GHZOrWState, (IQArray<Qubit>,Int64,Double), QVoid>((qs, state, alpha));
        }
    }

    public partial class T04_GHZOrWState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T04_GHZOrWState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T04_GHZOrWState_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T04_GHZOrWState_Test";
        protected ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, Int64> GHZOrWState
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_GHZOrWState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 131 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            foreach (var i in new Range(1L, 5L))
#line hidden
            {
#line 132 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                DistinguishStates_MultiQubit.Apply(((2L * i), 2L, StatePrep_GHZOrWState, GHZOrWState, true));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.GHZOrWState = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(GHZOrWState));
            this.StatePrep_GHZOrWState = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_GHZOrWState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T04_GHZOrWState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_DifferentBasis : Adjointable<(IQArray<Qubit>,Int64,Double)>, ICallable
    {
        public StatePrep_DifferentBasis(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Double)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Double) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "StatePrep_DifferentBasis";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.StatePrep_DifferentBasis";
        protected IAdjointable MicrosoftQuantumCanonApplyToEachA
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

        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> Body => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line 142 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((2D * alpha), qs[0L]));
#line 143 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 145 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            if ((state == 1L))
            {
#line 146 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line 150 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumCanonApplyToEachA.Apply((MicrosoftQuantumIntrinsicH, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Double), QVoid> AdjointBody => (__in__) =>
        {
            var (qs,state,alpha) = __in__;
#line hidden
            MicrosoftQuantumCanonApplyToEachA.Adjoint.Apply((MicrosoftQuantumIntrinsicH, qs));
#line hidden
            if ((state == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[1L]);
            }

#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[0L], qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicRy.Adjoint.Apply(((2D * alpha), qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachA = this.Factory.Get<IAdjointable>(typeof(Microsoft.Quantum.Canon.ApplyToEachA<>));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Double) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs, Int64 state, Double alpha)
        {
            return __m__.Run<StatePrep_DifferentBasis, (IQArray<Qubit>,Int64,Double), QVoid>((qs, state, alpha));
        }
    }

    public partial class T05_DifferentBasis_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T05_DifferentBasis_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T05_DifferentBasis_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T05_DifferentBasis_Test";
        protected ICallable<IQArray<Qubit>, Int64> DifferentBasis
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid> DistinguishStates_MultiQubit
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Double)> StatePrep_DifferentBasis
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 155 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            DistinguishStates_MultiQubit.Apply((2L, 2L, StatePrep_DifferentBasis, DifferentBasis, true));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.DifferentBasis = this.Factory.Get<ICallable<IQArray<Qubit>, Int64>>(typeof(DifferentBasis));
            this.DistinguishStates_MultiQubit = this.Factory.Get<ICallable<(Int64,Int64,IAdjointable,ICallable,Boolean), QVoid>>(typeof(DistinguishStates_MultiQubit));
            this.StatePrep_DifferentBasis = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Double)>>(typeof(StatePrep_DifferentBasis));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T05_DifferentBasis_Test, QVoid, QVoid>(QVoid.Instance);
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
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.StatePrep_A";
        protected IUnitary<(Double,Qubit)> MicrosoftQuantumIntrinsicRy
        {
            get;
            set;
        }

        public override Func<(Double,Qubit), QVoid> Body => (__in__) =>
        {
            var (alpha,q) = __in__;
#line 163 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
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

    public partial class T06_ControlledX_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T06_ControlledX_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T06_ControlledX_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T06_ControlledX_Test";
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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        protected ICallable<IQArray<Qubit>, QVoid> ControlledX
        {
            get;
            set;
        }

        protected IAdjointable<(Double,Qubit)> StatePrep_A
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 171 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 173 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                    foreach (var i in new Range(0L, 36L))
#line hidden
                    {
#line 174 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        var alpha = (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) * MicrosoftQuantumConvertIntAsDouble.Apply(i)) / 36D);
#line 177 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        StatePrep_A.Apply((alpha, qs[0L]));
#line 180 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        ControlledX.Apply(qs);
#line 183 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line 184 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
                        StatePrep_A.Adjoint.Apply((alpha, qs[0L]));
#line 187 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
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
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.ControlledX = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(ControlledX));
            this.StatePrep_A = this.Factory.Get<IAdjointable<(Double,Qubit)>>(typeof(StatePrep_A));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T06_ControlledX_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class CNOTWrapper : Adjointable<IQArray<Qubit>>, ICallable
    {
        public CNOTWrapper(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CNOTWrapper";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.CNOTWrapper";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 197 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<CNOTWrapper, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class T07_ControlledX_General_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T07_ControlledX_General_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T07_ControlledX_General_Test";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.T07_ControlledX_General_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> CNOTWrapper
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ControlledX_General
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ControlledX_General_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 206 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, CNOTWrapper, ControlledX_General_Reference));
#line 207 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((2L, ControlledX_General, ControlledX_General_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.CNOTWrapper = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CNOTWrapper));
            this.ControlledX_General = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ControlledX_General));
            this.ControlledX_General_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ControlledX_General_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T07_ControlledX_General_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}