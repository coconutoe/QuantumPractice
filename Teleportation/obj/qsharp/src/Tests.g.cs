#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T11_Entangle_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T11_Entangle_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"StatePrep_BellState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"ComposeTeleportation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bellPrepOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"getDescriptionOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"reconstructOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":9},\"Item2\":{\"Line\":5,\"Column\":15}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":6,\"Column\":9},\"Item2\":{\"Line\":6,\"Column\":13}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qMessage\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":7,\"Column\":9},\"Item2\":{\"Line\":7,\"Column\":17}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"ComposeTeleportation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":56,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportTestHelper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"teleportOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"setupPsiOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":19}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportTestHelper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportTestLoop\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"teleportOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportTestLoop\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":108,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T12_SendMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":128,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T12_SendMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":128,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T13_ReconstructMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T13_ReconstructMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T14_StandardTeleport_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T14_StandardTeleport_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":143,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportPreparedStateTestLoop\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"prepareAndSendMessageOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Pauli\"},{\"Case\":\"Bool\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"reconstructAndMeasureMessageOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},{\"Case\":\"Pauli\"}]]},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":108},\"Item2\":{\"Line\":1,\"Column\":138}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Pauli\"},{\"Case\":\"Bool\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},{\"Case\":\"Pauli\"}]]},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"TeleportPreparedStateTestLoop\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T15_PrepareAndSendMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":181,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T15_PrepareAndSendMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":181,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T16_ReconstructAndMeasureMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T16_ReconstructAndMeasureMessage_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":188,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":48}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T21_ReconstructMessage_PhiMinus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":195,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T21_ReconstructMessage_PhiMinus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":195,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T22_ReconstructMessage_PsiPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":201,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T22_ReconstructMessage_PsiPlus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":201,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":46}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T23_ReconstructMessage_PsiMinus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":207,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T23_ReconstructMessage_PsiMinus_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":207,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":47}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T31_MeasurementFreeTeleport_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":214,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T31_MeasurementFreeTeleport_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":214,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T41_EntangleThreeQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T41_EntangleThreeQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T42_ReconstructMessageWhenThreeEntangledQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":257,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":62}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.Teleportation\",\"Name\":\"T42_ReconstructMessageWhenThreeEntangledQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/Teleportation/Tests.qs\",\"Position\":{\"Item1\":257,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":62}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.Teleportation
{
    public partial class T11_Entangle_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_Entangle_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_Entangle_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T11_Entangle_Test";
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

        protected ICallable<(Qubit,Qubit), QVoid> Entangle
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit)> Entangle_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 19 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var (q0,q1) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 21 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    Entangle.Apply((q0, q1));
#line 24 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    Entangle_Reference.Adjoint.Apply((q0, q1));
#line 27 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertAllZero.Apply(new QArray<Qubit>(q0, q1));
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
                    Release.Apply(q0);
#line hidden
                    Release.Apply(q1);
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
            this.Entangle = this.Factory.Get<ICallable<(Qubit,Qubit), QVoid>>(typeof(Entangle));
            this.Entangle_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(Entangle_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_Entangle_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class StatePrep_BellState : Operation<(Qubit,Qubit,Int64), QVoid>, ICallable
    {
        public StatePrep_BellState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Int64)>, IApplyData
        {
            public In((Qubit,Qubit,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "StatePrep_BellState";
        String ICallable.FullName => "Quantum.Kata.Teleportation.StatePrep_BellState";
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

        public override Func<(Qubit,Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q1,q2,state) = __in__;
#line 39 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            MicrosoftQuantumIntrinsicH.Apply(q1);
#line 40 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((q1, q2));
#line 43 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            if (((state % 2L) == 1L))
            {
#line 45 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                MicrosoftQuantumIntrinsicZ.Apply(q2);
            }

#line 48 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            if (((state / 2L) == 1L))
            {
#line 49 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                MicrosoftQuantumIntrinsicX.Apply(q2);
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

        public override IApplyData __dataIn((Qubit,Qubit,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2, Int64 state)
        {
            return __m__.Run<StatePrep_BellState, (Qubit,Qubit,Int64), QVoid>((q1, q2, state));
        }
    }

    public partial class ComposeTeleportation : Operation<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>, ICallable
    {
        public ComposeTeleportation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((ICallable,ICallable,ICallable,Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits, ((IApplyData)Data.Item6)?.Qubits);
        }

        String ICallable.Name => "ComposeTeleportation";
        String ICallable.FullName => "Quantum.Kata.Teleportation.ComposeTeleportation";
        public override Func<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (bellPrepOp,getDescriptionOp,reconstructOp,qAlice,qBob,qMessage) = __in__;
#line 65 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            bellPrepOp.Apply((qAlice, qBob));
#line 66 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var classicalBits = getDescriptionOp.Apply<(Boolean,Boolean)>((qAlice, qMessage));
#line 70 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            reconstructOp.Apply((qBob, classicalBits));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,ICallable,ICallable,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable bellPrepOp, ICallable getDescriptionOp, ICallable reconstructOp, Qubit qAlice, Qubit qBob, Qubit qMessage)
        {
            return __m__.Run<ComposeTeleportation, (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>((bellPrepOp, getDescriptionOp, reconstructOp, qAlice, qBob, qMessage));
        }
    }

    public partial class TeleportTestHelper : Operation<(ICallable,IAdjointable), QVoid>, ICallable
    {
        public TeleportTestHelper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IAdjointable)>, IApplyData
        {
            public In((ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TeleportTestHelper";
        String ICallable.FullName => "Quantum.Kata.Teleportation.TeleportTestHelper";
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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<(ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (teleportOp,setupPsiOp) = __in__;
#line hidden
            {
#line 84 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 85 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qMessage = qs[0L];
#line 86 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qAlice = qs[1L];
#line 87 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qBob = qs[2L];
#line 88 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    setupPsiOp.Apply(qMessage);
#line 92 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    teleportOp.Apply((qAlice, qBob, qMessage));
#line 96 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    setupPsiOp.Adjoint.Apply(qBob);
#line 97 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertQubit.Apply((Result.Zero, qBob));
#line 98 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
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
            this.MicrosoftQuantumDiagnosticsAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn((ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable teleportOp, IAdjointable setupPsiOp)
        {
            return __m__.Run<TeleportTestHelper, (ICallable,IAdjointable), QVoid>((teleportOp, setupPsiOp));
        }
    }

    public partial class TeleportTestLoop : Operation<ICallable, QVoid>, ICallable
    {
        public TeleportTestLoop(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TeleportTestLoop";
        String ICallable.FullName => "Quantum.Kata.Teleportation.TeleportTestLoop";
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
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

        protected ICallable<(ICallable,IAdjointable), QVoid> TeleportTestHelper
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in__) =>
        {
            var teleportOp = __in__;
#line 112 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var setupPsiOps = (IQArray<IUnitary>)new QArray<IUnitary>(MicrosoftQuantumIntrinsicI, MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicRy.Partial(new Func<Qubit, (Double,Qubit)>((__arg1__) => (42D, __arg1__))));
#line 118 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var numRepetitions = 100L;
#line 119 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            foreach (var i in new Range(0L, (setupPsiOps.Length - 1L)))
#line hidden
            {
#line 120 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                foreach (var j in new Range(1L, numRepetitions))
#line hidden
                {
#line 121 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    TeleportTestHelper.Apply((teleportOp, setupPsiOps[i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.TeleportTestHelper = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(TeleportTestHelper));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable teleportOp)
        {
            return __m__.Run<TeleportTestLoop, ICallable, QVoid>(teleportOp);
        }
    }

    public partial class T12_SendMessage_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_SendMessage_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_SendMessage_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T12_SendMessage_Test";
        protected ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> ComposeTeleportation
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean)), QVoid> ReconstructMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 130 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var teleport = ComposeTeleportation.Partial(new Func<(Qubit,Qubit,Qubit), (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>((__arg1__) => (StatePrep_BellState.Partial(new Func<(Qubit,Qubit), (Qubit,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 0L))), SendMessage, ReconstructMessage_Reference, __arg1__.Item1, __arg1__.Item2, __arg1__.Item3)));
#line 131 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(teleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeTeleportation = this.Factory.Get<ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>>(typeof(ComposeTeleportation));
            this.ReconstructMessage_Reference = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean)), QVoid>>(typeof(ReconstructMessage_Reference));
            this.SendMessage = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_SendMessage_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_ReconstructMessage_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_ReconstructMessage_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_ReconstructMessage_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T13_ReconstructMessage_Test";
        protected ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> ComposeTeleportation
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean)), QVoid> ReconstructMessage
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 138 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var teleport = ComposeTeleportation.Partial(new Func<(Qubit,Qubit,Qubit), (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>((__arg1__) => (StatePrep_BellState.Partial(new Func<(Qubit,Qubit), (Qubit,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 0L))), SendMessage_Reference, ReconstructMessage, __arg1__.Item1, __arg1__.Item2, __arg1__.Item3)));
#line 139 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(teleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeTeleportation = this.Factory.Get<ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>>(typeof(ComposeTeleportation));
            this.ReconstructMessage = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean)), QVoid>>(typeof(ReconstructMessage));
            this.SendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage_Reference));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_ReconstructMessage_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_StandardTeleport_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_StandardTeleport_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_StandardTeleport_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T14_StandardTeleport_Test";
        protected ICallable<(Qubit,Qubit,Qubit), QVoid> StandardTeleport
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 145 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(StandardTeleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.StandardTeleport = this.Factory.Get<ICallable<(Qubit,Qubit,Qubit), QVoid>>(typeof(StandardTeleport));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_StandardTeleport_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class TeleportPreparedStateTestLoop : Operation<(ICallable,ICallable), QVoid>, ICallable
    {
        public TeleportPreparedStateTestLoop(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable)>, IApplyData
        {
            public In((ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TeleportPreparedStateTestLoop";
        String ICallable.FullName => "Quantum.Kata.Teleportation.TeleportPreparedStateTestLoop";
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

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable), QVoid> Body => (__in__) =>
        {
            var (prepareAndSendMessageOp,reconstructAndMeasureMessageOp) = __in__;
#line 157 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var messages = (IQArray<(Pauli,Boolean)>)new QArray<(Pauli,Boolean)>((Pauli.PauliX, false), (Pauli.PauliX, true), (Pauli.PauliY, false), (Pauli.PauliY, true), (Pauli.PauliZ, false), (Pauli.PauliZ, true));
#line 163 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var numRepetitions = 100L;
#line hidden
            {
#line 165 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var (qAlice,qBob) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 166 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    foreach (var i in new Range(0L, (messages.Length - 1L)))
#line hidden
                    {
#line 167 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                        foreach (var j in new Range(1L, numRepetitions))
#line hidden
                        {
#line 168 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            var (basis,sentState) = messages[i];
#line 169 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            StatePrep_BellState.Apply((qAlice, qBob, 0L));
#line 170 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            var classicalBits = prepareAndSendMessageOp.Apply<(Boolean,Boolean)>((qAlice, basis, sentState));
#line 171 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            var receivedState = reconstructAndMeasureMessageOp.Apply<Boolean>((qBob, classicalBits, basis));
#line 172 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumDiagnosticsEqualityFactB.Apply((receivedState, sentState, String.Format("Sent and received states were not equal for {0} eigenstate in {1} basis.", sentState, basis)));
#line 173 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(new QArray<Qubit>(qAlice, qBob));
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
                    Release.Apply(qAlice);
#line hidden
                    Release.Apply(qBob);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
        }

        public override IApplyData __dataIn((ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable prepareAndSendMessageOp, ICallable reconstructAndMeasureMessageOp)
        {
            return __m__.Run<TeleportPreparedStateTestLoop, (ICallable,ICallable), QVoid>((prepareAndSendMessageOp, reconstructAndMeasureMessageOp));
        }
    }

    public partial class T15_PrepareAndSendMessage_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T15_PrepareAndSendMessage_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T15_PrepareAndSendMessage_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T15_PrepareAndSendMessage_Test";
        protected ICallable<(Qubit,Pauli,Boolean), (Boolean,Boolean)> PrepareAndSendMessage
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean),Pauli), Boolean> ReconstructAndMeasureMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), QVoid> TeleportPreparedStateTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 183 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportPreparedStateTestLoop.Apply((PrepareAndSendMessage, ReconstructAndMeasureMessage_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareAndSendMessage = this.Factory.Get<ICallable<(Qubit,Pauli,Boolean), (Boolean,Boolean)>>(typeof(PrepareAndSendMessage));
            this.ReconstructAndMeasureMessage_Reference = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean),Pauli), Boolean>>(typeof(ReconstructAndMeasureMessage_Reference));
            this.TeleportPreparedStateTestLoop = this.Factory.Get<ICallable<(ICallable,ICallable), QVoid>>(typeof(TeleportPreparedStateTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T15_PrepareAndSendMessage_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T16_ReconstructAndMeasureMessage_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T16_ReconstructAndMeasureMessage_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T16_ReconstructAndMeasureMessage_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T16_ReconstructAndMeasureMessage_Test";
        protected ICallable<(Qubit,Pauli,Boolean), (Boolean,Boolean)> PrepareAndSendMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean),Pauli), Boolean> ReconstructAndMeasureMessage
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), QVoid> TeleportPreparedStateTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 190 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportPreparedStateTestLoop.Apply((PrepareAndSendMessage_Reference, ReconstructAndMeasureMessage));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.PrepareAndSendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Pauli,Boolean), (Boolean,Boolean)>>(typeof(PrepareAndSendMessage_Reference));
            this.ReconstructAndMeasureMessage = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean),Pauli), Boolean>>(typeof(ReconstructAndMeasureMessage));
            this.TeleportPreparedStateTestLoop = this.Factory.Get<ICallable<(ICallable,ICallable), QVoid>>(typeof(TeleportPreparedStateTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T16_ReconstructAndMeasureMessage_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T21_ReconstructMessage_PhiMinus_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_ReconstructMessage_PhiMinus_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_ReconstructMessage_PhiMinus_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T21_ReconstructMessage_PhiMinus_Test";
        protected ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> ComposeTeleportation
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean)), QVoid> ReconstructMessage_PhiMinus
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 197 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var teleport = ComposeTeleportation.Partial(new Func<(Qubit,Qubit,Qubit), (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>((__arg1__) => (StatePrep_BellState.Partial(new Func<(Qubit,Qubit), (Qubit,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 1L))), SendMessage_Reference, ReconstructMessage_PhiMinus, __arg1__.Item1, __arg1__.Item2, __arg1__.Item3)));
#line 198 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(teleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeTeleportation = this.Factory.Get<ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>>(typeof(ComposeTeleportation));
            this.ReconstructMessage_PhiMinus = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean)), QVoid>>(typeof(ReconstructMessage_PhiMinus));
            this.SendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage_Reference));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_ReconstructMessage_PhiMinus_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T22_ReconstructMessage_PsiPlus_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_ReconstructMessage_PsiPlus_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_ReconstructMessage_PsiPlus_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T22_ReconstructMessage_PsiPlus_Test";
        protected ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> ComposeTeleportation
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean)), QVoid> ReconstructMessage_PsiPlus
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 203 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var teleport = ComposeTeleportation.Partial(new Func<(Qubit,Qubit,Qubit), (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>((__arg1__) => (StatePrep_BellState.Partial(new Func<(Qubit,Qubit), (Qubit,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 2L))), SendMessage_Reference, ReconstructMessage_PsiPlus, __arg1__.Item1, __arg1__.Item2, __arg1__.Item3)));
#line 204 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(teleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeTeleportation = this.Factory.Get<ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>>(typeof(ComposeTeleportation));
            this.ReconstructMessage_PsiPlus = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean)), QVoid>>(typeof(ReconstructMessage_PsiPlus));
            this.SendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage_Reference));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_ReconstructMessage_PsiPlus_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T23_ReconstructMessage_PsiMinus_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_ReconstructMessage_PsiMinus_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_ReconstructMessage_PsiMinus_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T23_ReconstructMessage_PsiMinus_Test";
        protected ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid> ComposeTeleportation
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean)), QVoid> ReconstructMessage_PsiMinus
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TeleportTestLoop
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 209 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var teleport = ComposeTeleportation.Partial(new Func<(Qubit,Qubit,Qubit), (ICallable,ICallable,ICallable,Qubit,Qubit,Qubit)>((__arg1__) => (StatePrep_BellState.Partial(new Func<(Qubit,Qubit), (Qubit,Qubit,Int64)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, 3L))), SendMessage_Reference, ReconstructMessage_PsiMinus, __arg1__.Item1, __arg1__.Item2, __arg1__.Item3)));
#line 210 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            TeleportTestLoop.Apply(teleport);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeTeleportation = this.Factory.Get<ICallable<(ICallable,ICallable,ICallable,Qubit,Qubit,Qubit), QVoid>>(typeof(ComposeTeleportation));
            this.ReconstructMessage_PsiMinus = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean)), QVoid>>(typeof(ReconstructMessage_PsiMinus));
            this.SendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage_Reference));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
            this.TeleportTestLoop = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TeleportTestLoop));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_ReconstructMessage_PsiMinus_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T31_MeasurementFreeTeleport_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T31_MeasurementFreeTeleport_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T31_MeasurementFreeTeleport_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T31_MeasurementFreeTeleport_Test";
        protected ICallable Length
        {
            get;
            set;
        }

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

        protected ICallable<(Qubit,Qubit,Qubit), QVoid> MeasurementFreeTeleport
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit,Int64), QVoid> StatePrep_BellState
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 216 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var setupPsiOps = (IQArray<IUnitary>)new QArray<IUnitary>(MicrosoftQuantumIntrinsicI, MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicRy.Partial(new Func<Qubit, (Double,Qubit)>((__arg1__) => (42D, __arg1__))));
#line 217 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var numRepetitions = 100L;
#line hidden
            {
#line 219 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg2__ = null;
                try
                {
#line 220 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qMessage = qs[0L];
#line 221 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qAlice = qs[1L];
#line 222 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qBob = qs[2L];
#line 224 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    foreach (var i in new Range(0L, (setupPsiOps.Length - 1L)))
#line hidden
                    {
#line 225 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                        foreach (var j in new Range(1L, numRepetitions))
#line hidden
                        {
#line 226 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            setupPsiOps[i].Apply(qMessage);
#line 227 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            StatePrep_BellState.Apply((qAlice, qBob, 0L));
#line 228 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MeasurementFreeTeleport.Apply((qAlice, qBob, qMessage));
#line 229 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            setupPsiOps[i].Adjoint.Apply(qBob);
#line 230 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumDiagnosticsAssertQubit.Apply((Result.Zero, qBob));
#line 231 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                        }
                    }
                }
#line hidden
                catch (Exception __arg3__)
                {
                    __arg2__ = __arg3__;
                    throw __arg2__;
                }
#line hidden
                finally
                {
                    if (__arg2__ != null)
                    {
                        throw __arg2__;
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
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MeasurementFreeTeleport = this.Factory.Get<ICallable<(Qubit,Qubit,Qubit), QVoid>>(typeof(MeasurementFreeTeleport));
            this.StatePrep_BellState = this.Factory.Get<ICallable<(Qubit,Qubit,Int64), QVoid>>(typeof(StatePrep_BellState));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T31_MeasurementFreeTeleport_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T41_EntangleThreeQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T41_EntangleThreeQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T41_EntangleThreeQubits_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T41_EntangleThreeQubits_Test";
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

        protected ICallable<(Qubit,Qubit,Qubit), QVoid> EntangleThreeQubits
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> EntangleThreeQubits_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 241 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 242 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qAlice = qs[0L];
#line 243 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qBob = qs[1L];
#line 244 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qCharlie = qs[2L];
#line 247 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    EntangleThreeQubits.Apply((qAlice, qBob, qCharlie));
#line 250 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    EntangleThreeQubits_Reference.Adjoint.Apply((qAlice, qBob, qCharlie));
#line 253 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
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
            this.EntangleThreeQubits = this.Factory.Get<ICallable<(Qubit,Qubit,Qubit), QVoid>>(typeof(EntangleThreeQubits));
            this.EntangleThreeQubits_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(EntangleThreeQubits_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T41_EntangleThreeQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T42_ReconstructMessageWhenThreeEntangledQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T42_ReconstructMessageWhenThreeEntangledQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T42_ReconstructMessageWhenThreeEntangledQubits_Test";
        String ICallable.FullName => "Quantum.Kata.Teleportation.T42_ReconstructMessageWhenThreeEntangledQubits_Test";
        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

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

        protected IAdjointable<(Qubit,Qubit,Qubit)> EntangleThreeQubits_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,(Boolean,Boolean),Boolean), QVoid> ReconstructMessageWhenThreeEntangledQubits
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), (Boolean,Boolean)> SendMessage_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 260 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var setupPsiOps = (IQArray<IUnitary>)new QArray<IUnitary>(MicrosoftQuantumIntrinsicI, MicrosoftQuantumIntrinsicX, MicrosoftQuantumIntrinsicH, MicrosoftQuantumIntrinsicRy.Partial(new Func<Qubit, (Double,Qubit)>((__arg1__) => (42D, __arg1__))));
#line 261 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
            var numRepetitions = 100L;
#line hidden
            {
#line 263 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                var qs = Allocate.Apply(4L);
#line hidden
                Exception __arg2__ = null;
                try
                {
#line 264 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qMessage = qs[0L];
#line 265 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qAlice = qs[1L];
#line 266 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qBob = qs[2L];
#line 267 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    var qCharlie = qs[3L];
#line 269 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                    foreach (var i in new Range(0L, (setupPsiOps.Length - 1L)))
#line hidden
                    {
#line 270 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                        foreach (var j in new Range(1L, numRepetitions))
#line hidden
                        {
#line 271 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            setupPsiOps[i].Apply(qMessage);
#line 272 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            EntangleThreeQubits_Reference.Apply((qAlice, qBob, qCharlie));
#line 273 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            var (b1,b2) = SendMessage_Reference.Apply((qAlice, qMessage));
#line 274 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            var b3 = MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicM.Apply(qBob));
#line 275 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            ReconstructMessageWhenThreeEntangledQubits.Apply((qCharlie, (b1, b2), b3));
#line 276 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            setupPsiOps[i].Adjoint.Apply(qCharlie);
#line 277 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumDiagnosticsAssertQubit.Apply((Result.Zero, qCharlie));
#line 278 "G:\\量子实习\\quantumKatas-VS\\Teleportation\\Tests.qs"
                            MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                        }
                    }
                }
#line hidden
                catch (Exception __arg3__)
                {
                    __arg2__ = __arg3__;
                    throw __arg2__;
                }
#line hidden
                finally
                {
                    if (__arg2__ != null)
                    {
                        throw __arg2__;
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
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsAssertQubit = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertQubit));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.EntangleThreeQubits_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(EntangleThreeQubits_Reference));
            this.ReconstructMessageWhenThreeEntangledQubits = this.Factory.Get<ICallable<(Qubit,(Boolean,Boolean),Boolean), QVoid>>(typeof(ReconstructMessageWhenThreeEntangledQubits));
            this.SendMessage_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), (Boolean,Boolean)>>(typeof(SendMessage_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T42_ReconstructMessageWhenThreeEntangledQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}