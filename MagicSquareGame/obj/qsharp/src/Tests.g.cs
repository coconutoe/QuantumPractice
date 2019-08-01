#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"SignFromBool\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"SignFromBool\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T11_ValidMove_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T11_ValidMove_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":23,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T12_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T12_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"RunTrials\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"moves\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"RunTrials\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ClassicalRunner\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"rowIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"columnIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ClassicalRunner\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T13_ClassicalStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T13_ClassicalStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"taskImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":39},\"Item2\":{\"Line\":2,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T21_CreateEntangledState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T21_CreateEntangledState_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"array\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":33}}]}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[{\"Case\":\"ValidName\",\"Fields\":[\"T\"]}],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Null\"}}]}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":47}}]}}]},{\"Case\":\"TypeParameter\",\"Fields\":[{\"Origin\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"TypeName\":\"T\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":47}}]}}]}]]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"Pairs\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ControlledWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":67}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ControlledWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ControlledWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":96}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.MagicSquareGame.ControlledWrapper\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ControlledWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":96}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.MagicSquareGame.ControlledWrapper\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ControlledWrapper\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":130,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":96}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.MagicSquareGame.ControlledWrapper\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertOperationsEqualWithPhase\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":134,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op1\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op2\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":91}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertOperationsEqualWithPhase\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":134,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertOperationsMutuallyCommute\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"operations\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"AssertOperationsMutuallyCommute\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"MinusI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":21}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"MinusI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"MinusI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.MagicSquareGame.MinusI\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"MinusI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.MagicSquareGame.MinusI\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"MinusI\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":146,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.MagicSquareGame.MinusI\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ApplyObservablesImpl\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"column\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"ApplyObservablesImpl\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T22_GetMagicObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":158,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T22_GetMagicObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":158,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T23_ApplyMagicObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":177,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T23_ApplyMagicObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":177,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T24_MeasureObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T24_MeasureObservables_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":191,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T25_MeasureOperator_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":224,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T25_MeasureOperator_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":224,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"QuantumRunner\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":258,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"referee\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"rowIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":30},\"Item2\":{\"Line\":2,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"columnIndex\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":30},\"Item2\":{\"Line\":3,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"Item2\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"QuantumRunner\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":258,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T26_QuantumStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":264,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T26_QuantumStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":264,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T27_PlayQuantumMagicSquare_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"T27_PlayQuantumMagicSquare_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":272,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"DrawMagicSquare\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":281,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"alice\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"row\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bob\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"column\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.MagicSquareGame\",\"Name\":\"DrawMagicSquare\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/MagicSquareGame/Tests.qs\",\"Position\":{\"Item1\":281,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.MagicSquareGame
{
    public partial class SignFromBool : Function<Boolean, Int64>, ICallable
    {
        public SignFromBool(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SignFromBool";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.SignFromBool";
        public override Func<Boolean, Int64> Body => (__in__) =>
        {
            var input = __in__;
#line 21 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return (input ? 1L : -(1L));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Boolean input)
        {
            return __m__.Run<SignFromBool, Boolean, Int64>(input);
        }
    }

    public partial class T11_ValidMove_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_ValidMove_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_ValidMove_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T11_ValidMove_Test";
        protected ICallable MicrosoftQuantumArraysMapped
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<Boolean, Int64> SignFromBool
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Boolean> ValidAliceMove
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Boolean> ValidAliceMove_Reference
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Boolean> ValidBobMove
        {
            get;
            set;
        }

        protected ICallable<IQArray<Int64>, Boolean> ValidBobMove_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 26 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var i in new Range(0L, (1L << (int)(3L - 1L))))
#line hidden
            {
#line 27 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var cells = (IQArray<Int64>)MicrosoftQuantumArraysMapped.Apply<IQArray<Int64>>((SignFromBool, MicrosoftQuantumConvertIntAsBoolArray.Apply((i, 3L))));
#line 28 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((ValidAliceMove.Apply(cells) == ValidAliceMove_Reference.Apply(cells)), String.Format("Incorrect Alice move validity for {0}", cells)));
#line 30 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((ValidBobMove.Apply(cells) == ValidBobMove_Reference.Apply(cells)), String.Format("Incorrect Bob move validity for {0}", cells)));
            }

#line 35 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var cellsOutOfRange in new QArray<IQArray<Int64>>(new QArray<Int64>(1L, -(2L), 10L), new QArray<Int64>(-(3L), 0L, -(2L)), new QArray<Int64>(-(1L), 2L, 1L), new QArray<Int64>(2L, 3L, 4L)))
#line hidden
            {
#line 36 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((ValidAliceMove.Apply(cellsOutOfRange) == false), String.Format("Invalid Alice move judged valid for {0}", cellsOutOfRange)));
#line 38 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((ValidBobMove.Apply(cellsOutOfRange) == false), String.Format("Invalid Bob move judged valid for {0}", cellsOutOfRange)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMapped = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Mapped<,>));
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.SignFromBool = this.Factory.Get<ICallable<Boolean, Int64>>(typeof(SignFromBool));
            this.ValidAliceMove = this.Factory.Get<ICallable<IQArray<Int64>, Boolean>>(typeof(ValidAliceMove));
            this.ValidAliceMove_Reference = this.Factory.Get<ICallable<IQArray<Int64>, Boolean>>(typeof(ValidAliceMove_Reference));
            this.ValidBobMove = this.Factory.Get<ICallable<IQArray<Int64>, Boolean>>(typeof(ValidBobMove));
            this.ValidBobMove_Reference = this.Factory.Get<ICallable<IQArray<Int64>, Boolean>>(typeof(ValidBobMove_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_ValidMove_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_WinCondition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_WinCondition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_WinCondition_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T12_WinCondition_Test";
        protected ICallable MicrosoftQuantumArraysMapped
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<Boolean, Int64> SignFromBool
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean> WinCondition
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean> WinCondition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 47 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var i in new Range(0L, (1L << (int)(3L - 1L))))
#line hidden
            {
#line 48 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                foreach (var j in new Range(0L, (1L << (int)(3L - 1L))))
#line hidden
                {
#line 49 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    foreach (var rowIndex in new Range(0L, 2L))
#line hidden
                    {
#line 50 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        foreach (var columnIndex in new Range(0L, 2L))
#line hidden
                        {
#line 51 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                            var row = (IQArray<Int64>)MicrosoftQuantumArraysMapped.Apply<IQArray<Int64>>((SignFromBool, MicrosoftQuantumConvertIntAsBoolArray.Apply((i, 3L))));
#line 52 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                            var column = (IQArray<Int64>)MicrosoftQuantumArraysMapped.Apply<IQArray<Int64>>((SignFromBool, MicrosoftQuantumConvertIntAsBoolArray.Apply((j, 3L))));
#line 54 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                            MicrosoftQuantumDiagnosticsFact.Apply(((WinCondition.Apply((rowIndex, columnIndex, row, column)) == WinCondition_Reference.Apply((rowIndex, columnIndex, row, column))), (String.Format("Incorrect win condition for rowIndex={0}, columnIndex={1}, ", rowIndex, columnIndex) + String.Format(" row={0}, column={1}", row, column))));
                        }
                    }
                }
            }

#line 65 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var aliceOutOfRange = (IQArray<Int64>)new QArray<Int64>(-(1L), -(1L), 7L);
#line 66 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var bobInRange = (IQArray<Int64>)new QArray<Int64>(-(1L), 1L, 1L);
#line 67 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsFact.Apply((!(WinCondition.Apply((0L, 0L, aliceOutOfRange, bobInRange))), String.Format("Win condition is wrong for Alice={0}, row=0, Bob={1}, column=0", aliceOutOfRange, bobInRange)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMapped = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Mapped<,>));
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.SignFromBool = this.Factory.Get<ICallable<Boolean, Int64>>(typeof(SignFromBool));
            this.WinCondition = this.Factory.Get<ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean>>(typeof(WinCondition));
            this.WinCondition_Reference = this.Factory.Get<ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean>>(typeof(WinCondition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_WinCondition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class RunTrials : Operation<(Int64,ICallable), Int64>, ICallable
    {
        public RunTrials(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "RunTrials";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.RunTrials";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean> WinCondition_Reference
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Int64> Body => (__in__) =>
        {
            var (n,moves) = __in__;
#line 74 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var wins = 0L;
#line 75 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var i in new Range(1L, n))
#line hidden
            {
#line 76 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var rowIndex = MicrosoftQuantumMathRandomInt.Apply(3L);
#line 77 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var columnIndex = MicrosoftQuantumMathRandomInt.Apply(3L);
#line 78 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var (alice,bob) = ((IQArray<Int64>,IQArray<Int64>))moves.Apply<(IQArray<Int64>,IQArray<Int64>)>((rowIndex, columnIndex));
#line 79 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                if (WinCondition_Reference.Apply((rowIndex, columnIndex, alice, bob)))
                {
#line 80 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    wins = (wins + 1L);
                }
            }

#line 83 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return wins;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.WinCondition_Reference = this.Factory.Get<ICallable<(Int64,Int64,IQArray<Int64>,IQArray<Int64>), Boolean>>(typeof(WinCondition_Reference));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 n, ICallable moves)
        {
            return __m__.Run<RunTrials, (Int64,ICallable), Int64>((n, moves));
        }
    }

    public partial class ClassicalRunner : Operation<(Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>, ICallable
    {
        public ClassicalRunner(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        public class Out : QTuple<(IQArray<Int64>,IQArray<Int64>)>, IApplyData
        {
            public Out((IQArray<Int64>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ClassicalRunner";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.ClassicalRunner";
        protected ICallable<Int64, IQArray<Int64>> AliceClassical
        {
            get;
            set;
        }

        protected ICallable<Int64, IQArray<Int64>> BobClassical
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (IQArray<Int64>,IQArray<Int64>)> Body => (__in__) =>
        {
            var (rowIndex,columnIndex) = __in__;
#line 87 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return (AliceClassical.Apply(rowIndex), BobClassical.Apply(columnIndex));
        }

        ;
        public override void Init()
        {
            this.AliceClassical = this.Factory.Get<ICallable<Int64, IQArray<Int64>>>(typeof(AliceClassical));
            this.BobClassical = this.Factory.Get<ICallable<Int64, IQArray<Int64>>>(typeof(BobClassical));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((IQArray<Int64>,IQArray<Int64>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(IQArray<Int64>,IQArray<Int64>)> Run(IOperationFactory __m__, Int64 rowIndex, Int64 columnIndex)
        {
            return __m__.Run<ClassicalRunner, (Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>((rowIndex, columnIndex));
        }
    }

    public partial class T13_ClassicalStrategy_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_ClassicalStrategy_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_ClassicalStrategy_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T13_ClassicalStrategy_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), (IQArray<Int64>,IQArray<Int64>)> ClassicalRunner
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Int64> RunTrials
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 91 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var wins = RunTrials.Apply((1000L, ClassicalRunner));
#line 92 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsFact.Apply(((wins >= 850L), String.Format("The classical strategy implemented is not optimal: win rate {0}", (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / 1000D))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.ClassicalRunner = this.Factory.Get<ICallable<(Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>>(typeof(ClassicalRunner));
            this.RunTrials = this.Factory.Get<ICallable<(Int64,ICallable), Int64>>(typeof(RunTrials));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_ClassicalStrategy_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

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
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.AssertEqualOnZeroState";
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
            var (N,taskImpl,refImpl) = __in__;
#line hidden
            {
#line 99 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var qs = Allocate.Apply(N);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 101 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    taskImpl.Apply(qs);
#line 104 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    refImpl.Adjoint.Apply(qs);
#line 107 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable taskImpl, IAdjointable refImpl)
        {
            return __m__.Run<AssertEqualOnZeroState, (Int64,ICallable,IAdjointable), QVoid>((N, taskImpl, refImpl));
        }
    }

    public partial class T21_CreateEntangledState_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_CreateEntangledState_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_CreateEntangledState_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T21_CreateEntangledState_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> CreateEntangledState
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> CreateEntangledState_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 112 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            AssertEqualOnZeroState.Apply((4L, CreateEntangledState, CreateEntangledState_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.CreateEntangledState = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(CreateEntangledState));
            this.CreateEntangledState_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CreateEntangledState_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_CreateEntangledState_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class Pairs<__T__> : Function<IQArray<__T__>, IQArray<(__T__,__T__)>>, ICallable
    {
        public Pairs(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Pairs";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.Pairs";
        protected ICallable Length
        {
            get;
            set;
        }

        public override Func<IQArray<__T__>, IQArray<(__T__,__T__)>> Body => (__in__) =>
        {
            var array = __in__;
#line 118 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var N = array.Length;
#line 119 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var length = ((N * (N - 1L)) / 2L);
#line 120 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var pairs = QArray<(__T__,__T__)>.Create(length);
#line 121 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var i = 0L;
#line 122 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var j in new Range(0L, (N - 1L)))
#line hidden
            {
#line 123 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                foreach (var k in new Range((j + 1L), (N - 1L)))
#line hidden
                {
#line 124 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    pairs.Modify(i, (array[j], array[k]));
#line 125 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    i = (i + 1L);
                }
            }

#line 128 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return pairs;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __dataIn(IQArray<__T__> data) => data;
        public override IApplyData __dataOut(IQArray<(__T__,__T__)> data) => data;
        public static System.Threading.Tasks.Task<IQArray<(__T__,__T__)>> Run(IOperationFactory __m__, IQArray<__T__> array)
        {
            return __m__.Run<Pairs<__T__>, IQArray<__T__>, IQArray<(__T__,__T__)>>(array);
        }
    }

    public partial class ControlledWrapper : Unitary<(IUnitary,IQArray<Qubit>)>, ICallable
    {
        public ControlledWrapper(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IQArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ControlledWrapper";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.ControlledWrapper";
        protected ICallable MicrosoftQuantumArraysHead
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysRest
        {
            get;
            set;
        }

        public override Func<(IUnitary,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 132 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            op.Controlled.Apply((new QArray<Qubit>(MicrosoftQuantumArraysHead.Apply<Qubit>(qs)), MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Controlled.Adjoint.Apply((new QArray<Qubit>(MicrosoftQuantumArraysHead.Apply<Qubit>(qs)), MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Controlled.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(MicrosoftQuantumArraysHead.Apply<Qubit>(qs)), MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(op,qs)) = __in__;
#line hidden
            op.Controlled.Adjoint.Controlled.Apply((__controlQubits__, (new QArray<Qubit>(MicrosoftQuantumArraysHead.Apply<Qubit>(qs)), MicrosoftQuantumArraysRest.Apply<IQArray<Qubit>>(qs))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysHead = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Head<>));
            this.MicrosoftQuantumArraysRest = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Rest<>));
        }

        public override IApplyData __dataIn((IUnitary,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary op, IQArray<Qubit> qs)
        {
            return __m__.Run<ControlledWrapper, (IUnitary,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class AssertOperationsEqualWithPhase : Operation<(Int64,IUnitary,IUnitary), QVoid>, ICallable
    {
        public AssertOperationsEqualWithPhase(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,IUnitary,IUnitary)>, IApplyData
        {
            public In((Int64,IUnitary,IUnitary) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertOperationsEqualWithPhase";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.AssertOperationsEqualWithPhase";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,IQArray<Qubit>)> ControlledWrapper
        {
            get;
            set;
        }

        public override Func<(Int64,IUnitary,IUnitary), QVoid> Body => (__in__) =>
        {
            var (N,op1,op2) = __in__;
#line 137 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((N + 1L), ControlledWrapper.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg1__) => (op1, __arg1__))), ControlledWrapper.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (op2, __arg2__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.ControlledWrapper = this.Factory.Get<IUnitary<(IUnitary,IQArray<Qubit>)>>(typeof(ControlledWrapper));
        }

        public override IApplyData __dataIn((Int64,IUnitary,IUnitary) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, IUnitary op1, IUnitary op2)
        {
            return __m__.Run<AssertOperationsEqualWithPhase, (Int64,IUnitary,IUnitary), QVoid>((N, op1, op2));
        }
    }

    public partial class AssertOperationsMutuallyCommute : Operation<IQArray<IUnitary>, QVoid>, ICallable
    {
        public AssertOperationsMutuallyCommute(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AssertOperationsMutuallyCommute";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.AssertOperationsMutuallyCommute";
        protected ICallable MicrosoftQuantumCanonBoundCA
        {
            get;
            set;
        }

        protected ICallable<(Int64,IUnitary,IUnitary), QVoid> AssertOperationsEqualWithPhase
        {
            get;
            set;
        }

        protected ICallable Pairs
        {
            get;
            set;
        }

        public override Func<IQArray<IUnitary>, QVoid> Body => (__in__) =>
        {
            var operations = __in__;
#line 142 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var (a,b) in Pairs.Apply<IQArray<(IUnitary,IUnitary)>>(operations))
#line hidden
            {
#line 143 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                AssertOperationsEqualWithPhase.Apply((2L, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(a, b)), MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(new QArray<IUnitary>(b, a))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBoundCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BoundCA<>));
            this.AssertOperationsEqualWithPhase = this.Factory.Get<ICallable<(Int64,IUnitary,IUnitary), QVoid>>(typeof(AssertOperationsEqualWithPhase));
            this.Pairs = this.Factory.Get<ICallable>(typeof(Pairs<>));
        }

        public override IApplyData __dataIn(IQArray<IUnitary> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IUnitary> operations)
        {
            return __m__.Run<AssertOperationsMutuallyCommute, IQArray<IUnitary>, QVoid>(operations);
        }
    }

    public partial class MinusI : Unitary<IQArray<Qubit>>, ICallable
    {
        public MinusI(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MinusI";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.MinusI";
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
#line 148 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicZ.Apply(qs[0L]);
#line 149 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 150 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicZ.Apply(qs[0L]);
#line 151 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
#line hidden
            MicrosoftQuantumIntrinsicZ.Adjoint.Apply(qs[0L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
#line hidden
            MicrosoftQuantumIntrinsicZ.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicX.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicZ.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicZ.Adjoint.Controlled.Apply((__controlQubits__, qs[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<MinusI, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ApplyObservablesImpl : Function<(Int64,Int64), IUnitary>, ICallable
    {
        public ApplyObservablesImpl(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ApplyObservablesImpl";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.ApplyObservablesImpl";
        protected IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)> ApplyMagicObservables_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), (Int64,IQArray<Pauli>)> GetMagicObservables
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), IUnitary> Body => (__in__) =>
        {
            var (row,column) = __in__;
#line 156 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return ApplyMagicObservables_Reference.Partial(new Func<IQArray<Qubit>, ((Int64,IQArray<Pauli>),IQArray<Qubit>)>((__arg1__) => (GetMagicObservables.Apply((row, column)), __arg1__)));
        }

        ;
        public override void Init()
        {
            this.ApplyMagicObservables_Reference = this.Factory.Get<IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)>>(typeof(ApplyMagicObservables_Reference));
            this.GetMagicObservables = this.Factory.Get<ICallable<(Int64,Int64), (Int64,IQArray<Pauli>)>>(typeof(GetMagicObservables));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, Int64 row, Int64 column)
        {
            return __m__.Run<ApplyObservablesImpl, (Int64,Int64), IUnitary>((row, column));
        }
    }

    public partial class T22_GetMagicObservables_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_GetMagicObservables_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_GetMagicObservables_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T22_GetMagicObservables_Test";
        protected ICallable MicrosoftQuantumArraysMapped
        {
            get;
            set;
        }

        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonBoundCA
        {
            get;
            set;
        }

        protected ICallable<Range, IQArray<Int64>> MicrosoftQuantumConvertRangeAsIntArray
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicI
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), IUnitary> ApplyObservablesImpl
        {
            get;
            set;
        }

        protected ICallable<(Int64,IUnitary,IUnitary), QVoid> AssertOperationsEqualWithPhase
        {
            get;
            set;
        }

        protected ICallable<IQArray<IUnitary>, QVoid> AssertOperationsMutuallyCommute
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> MinusI
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 162 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var row in new Range(0L, 2L))
#line hidden
            {
#line 163 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var observables = (IQArray<IUnitary>)MicrosoftQuantumArraysMapped.Apply<IQArray<IUnitary>>((ApplyObservablesImpl.Partial(new Func<Int64, (Int64,Int64)>((__arg1__) => (row, __arg1__))), MicrosoftQuantumConvertRangeAsIntArray.Apply(new Range(0L, 2L))));
#line 165 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                AssertOperationsEqualWithPhase.Apply((2L, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(observables), MicrosoftQuantumCanonApplyToEachCA.Partial(new Func<IQArray<Qubit>, (IUnitary,IQArray<Qubit>)>((__arg2__) => (MicrosoftQuantumIntrinsicI, __arg2__)))));
#line 166 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                AssertOperationsMutuallyCommute.Apply(observables);
            }

#line 168 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var column in new Range(0L, 2L))
#line hidden
            {
#line 169 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var observables = (IQArray<IUnitary>)MicrosoftQuantumArraysMapped.Apply<IQArray<IUnitary>>((ApplyObservablesImpl.Partial(new Func<Int64, (Int64,Int64)>((__arg3__) => (__arg3__, column))), MicrosoftQuantumConvertRangeAsIntArray.Apply(new Range(0L, 2L))));
#line 171 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                AssertOperationsEqualWithPhase.Apply((2L, MicrosoftQuantumCanonBoundCA.Apply<IUnitary>(observables), MinusI));
#line 172 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                AssertOperationsMutuallyCommute.Apply(observables);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMapped = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Mapped<,>));
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.MicrosoftQuantumCanonBoundCA = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.BoundCA<>));
            this.MicrosoftQuantumConvertRangeAsIntArray = this.Factory.Get<ICallable<Range, IQArray<Int64>>>(typeof(Microsoft.Quantum.Convert.RangeAsIntArray));
            this.MicrosoftQuantumIntrinsicI = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.I));
            this.ApplyObservablesImpl = this.Factory.Get<ICallable<(Int64,Int64), IUnitary>>(typeof(ApplyObservablesImpl));
            this.AssertOperationsEqualWithPhase = this.Factory.Get<ICallable<(Int64,IUnitary,IUnitary), QVoid>>(typeof(AssertOperationsEqualWithPhase));
            this.AssertOperationsMutuallyCommute = this.Factory.Get<ICallable<IQArray<IUnitary>, QVoid>>(typeof(AssertOperationsMutuallyCommute));
            this.MinusI = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(MinusI));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_GetMagicObservables_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T23_ApplyMagicObservables_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_ApplyMagicObservables_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_ApplyMagicObservables_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T23_ApplyMagicObservables_Test";
        protected IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)> ApplyMagicObservables
        {
            get;
            set;
        }

        protected IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)> ApplyMagicObservables_Reference
        {
            get;
            set;
        }

        protected ICallable<(Int64,IUnitary,IUnitary), QVoid> AssertOperationsEqualWithPhase
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 180 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var sign in new QArray<Int64>(-(1L), 1L))
#line hidden
            {
#line 181 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                foreach (var obs1 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                {
#line 182 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    foreach (var obs2 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                    {
#line 183 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        var obs = ((Int64,IQArray<Pauli>))(sign, new QArray<Pauli>(obs1, obs2));
#line 184 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        AssertOperationsEqualWithPhase.Apply((2L, ApplyMagicObservables.Partial(new Func<IQArray<Qubit>, ((Int64,IQArray<Pauli>),IQArray<Qubit>)>((__arg1__) => (obs, __arg1__))), ApplyMagicObservables_Reference.Partial(new Func<IQArray<Qubit>, ((Int64,IQArray<Pauli>),IQArray<Qubit>)>((__arg2__) => (obs, __arg2__)))));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ApplyMagicObservables = this.Factory.Get<IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)>>(typeof(ApplyMagicObservables));
            this.ApplyMagicObservables_Reference = this.Factory.Get<IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)>>(typeof(ApplyMagicObservables_Reference));
            this.AssertOperationsEqualWithPhase = this.Factory.Get<ICallable<(Int64,IUnitary,IUnitary), QVoid>>(typeof(AssertOperationsEqualWithPhase));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_ApplyMagicObservables_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T24_MeasureObservables_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T24_MeasureObservables_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T24_MeasureObservables_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T24_MeasureObservables_Test";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
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

        protected ICallable<((Int64,IQArray<Pauli>),IQArray<Qubit>), Result> MeasureObservable
        {
            get;
            set;
        }

        protected ICallable<((Int64,IQArray<Pauli>),IQArray<Qubit>), Result> MeasureObservable_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 193 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 194 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    foreach (var sign in new QArray<Int64>(-(1L), 1L))
#line hidden
                    {
#line 195 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        foreach (var obs1 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                        {
#line 196 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                            foreach (var obs2 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                            {
#line 197 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                foreach (var i in new Range(1L, 100L))
#line hidden
                                {
#line 199 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    if ((((i % 4L) / 2L) == 1L))
                                    {
#line 200 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                        MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
                                    }

#line 202 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    if ((((i % 4L) % 2L) == 1L))
                                    {
#line 203 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                        MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
                                    }

#line 205 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, qs));
#line 207 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    var observable = ((Int64,IQArray<Pauli>))(sign, new QArray<Pauli>(obs1, obs2));
#line 208 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    var result = MeasureObservable_Reference.Apply((observable, qs));
#line 213 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumDiagnosticsFact.Apply(((MeasureObservable.Apply((observable, qs)) == result), String.Format("Observable measurement result differs from the reference result for observable {0}", observable)));
#line 215 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                                }
                            }
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MeasureObservable = this.Factory.Get<ICallable<((Int64,IQArray<Pauli>),IQArray<Qubit>), Result>>(typeof(MeasureObservable));
            this.MeasureObservable_Reference = this.Factory.Get<ICallable<((Int64,IQArray<Pauli>),IQArray<Qubit>), Result>>(typeof(MeasureObservable_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T24_MeasureObservables_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T25_MeasureOperator_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T25_MeasureOperator_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T25_MeasureOperator_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T25_MeasureOperator_Test";
        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
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

        protected IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)> ApplyMagicObservables_Reference
        {
            get;
            set;
        }

        protected ICallable<(IControllable,IQArray<Qubit>), Result> MeasureOperator
        {
            get;
            set;
        }

        protected ICallable<(IControllable,IQArray<Qubit>), Result> MeasureOperator_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 226 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 227 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    foreach (var sign in new QArray<Int64>(-(1L), 1L))
#line hidden
                    {
#line 228 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        foreach (var obs1 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                        {
#line 229 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                            foreach (var obs2 in new QArray<Pauli>(Pauli.PauliI, Pauli.PauliX, Pauli.PauliY, Pauli.PauliZ))
#line hidden
                            {
#line 230 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                foreach (var i in new Range(1L, 100L))
#line hidden
                                {
#line 232 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    if ((((i % 4L) / 2L) == 1L))
                                    {
#line 233 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                        MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
                                    }

#line 235 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    if ((((i % 4L) % 2L) == 1L))
                                    {
#line 236 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                        MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
                                    }

#line 238 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumCanonApplyToEach.Apply((MicrosoftQuantumIntrinsicH, qs));
#line 240 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    var observable = ((Int64,IQArray<Pauli>))(sign, new QArray<Pauli>(obs1, obs2));
#line 241 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    var op = ApplyMagicObservables_Reference.Partial(new Func<IQArray<Qubit>, ((Int64,IQArray<Pauli>),IQArray<Qubit>)>((__arg3__) => (observable, __arg3__)));
#line 242 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    var result = MeasureOperator_Reference.Apply((op, qs));
#line 247 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumDiagnosticsFact.Apply(((MeasureOperator.Apply((op, qs)) == result), String.Format("Operator measurement result differs from the reference result for observable {0}", observable)));
#line 249 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
                                }
                            }
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.ApplyMagicObservables_Reference = this.Factory.Get<IUnitary<((Int64,IQArray<Pauli>),IQArray<Qubit>)>>(typeof(ApplyMagicObservables_Reference));
            this.MeasureOperator = this.Factory.Get<ICallable<(IControllable,IQArray<Qubit>), Result>>(typeof(MeasureOperator));
            this.MeasureOperator_Reference = this.Factory.Get<ICallable<(IControllable,IQArray<Qubit>), Result>>(typeof(MeasureOperator_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T25_MeasureOperator_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class QuantumRunner : Operation<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>, ICallable
    {
        public QuantumRunner(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,Int64,Int64)>, IApplyData
        {
            public In((ICallable,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        public class Out : QTuple<(IQArray<Int64>,IQArray<Int64>)>, IApplyData
        {
            public Out((IQArray<Int64>,IQArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "QuantumRunner";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.QuantumRunner";
        protected ICallable<(Int64,IQArray<Qubit>), IQArray<Int64>> AliceQuantum
        {
            get;
            set;
        }

        protected ICallable<(Int64,IQArray<Qubit>), IQArray<Int64>> BobQuantum
        {
            get;
            set;
        }

        public override Func<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)> Body => (__in__) =>
        {
            var (referee,rowIndex,columnIndex) = __in__;
#line 262 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            return referee.Apply<(IQArray<Int64>,IQArray<Int64>)>((AliceQuantum.Partial(new Func<IQArray<Qubit>, (Int64,IQArray<Qubit>)>((__arg1__) => (rowIndex, __arg1__))), BobQuantum.Partial(new Func<IQArray<Qubit>, (Int64,IQArray<Qubit>)>((__arg2__) => (columnIndex, __arg2__)))));
        }

        ;
        public override void Init()
        {
            this.AliceQuantum = this.Factory.Get<ICallable<(Int64,IQArray<Qubit>), IQArray<Int64>>>(typeof(AliceQuantum));
            this.BobQuantum = this.Factory.Get<ICallable<(Int64,IQArray<Qubit>), IQArray<Int64>>>(typeof(BobQuantum));
        }

        public override IApplyData __dataIn((ICallable,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((IQArray<Int64>,IQArray<Int64>) data) => new Out(data);
        public static System.Threading.Tasks.Task<(IQArray<Int64>,IQArray<Int64>)> Run(IOperationFactory __m__, ICallable referee, Int64 rowIndex, Int64 columnIndex)
        {
            return __m__.Run<QuantumRunner, (ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>((referee, rowIndex, columnIndex));
        }
    }

    public partial class T26_QuantumStrategy_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T26_QuantumStrategy_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T26_QuantumStrategy_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T26_QuantumStrategy_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), (IQArray<Int64>,IQArray<Int64>)> PlayQuantumMagicSquare_Reference
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)> QuantumRunner
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Int64> RunTrials
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 266 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var N = 1000L;
#line 267 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var wins = RunTrials.Apply((N, QuantumRunner.Partial(new Func<(Int64,Int64), (ICallable,Int64,Int64)>((__arg1__) => (PlayQuantumMagicSquare_Reference, __arg1__.Item1, __arg1__.Item2)))));
#line 268 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsFact.Apply(((wins == N), String.Format("Alice and Bob's quantum strategy is not optimal: win rate {0}", (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / MicrosoftQuantumConvertIntAsDouble.Apply(N)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.PlayQuantumMagicSquare_Reference = this.Factory.Get<ICallable<(ICallable,ICallable), (IQArray<Int64>,IQArray<Int64>)>>(typeof(PlayQuantumMagicSquare_Reference));
            this.QuantumRunner = this.Factory.Get<ICallable<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>>(typeof(QuantumRunner));
            this.RunTrials = this.Factory.Get<ICallable<(Int64,ICallable), Int64>>(typeof(RunTrials));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T26_QuantumStrategy_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T27_PlayQuantumMagicSquare_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T27_PlayQuantumMagicSquare_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T27_PlayQuantumMagicSquare_Test";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.T27_PlayQuantumMagicSquare_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), (IQArray<Int64>,IQArray<Int64>)> PlayQuantumMagicSquare
        {
            get;
            set;
        }

        protected ICallable<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)> QuantumRunner
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Int64> RunTrials
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 274 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var N = 1000L;
#line 275 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            var wins = RunTrials.Apply((N, QuantumRunner.Partial(new Func<(Int64,Int64), (ICallable,Int64,Int64)>((__arg1__) => (PlayQuantumMagicSquare, __arg1__.Item1, __arg1__.Item2)))));
#line 276 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Win rate {0}", (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / MicrosoftQuantumConvertIntAsDouble.Apply(N))));
#line 277 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsFact.Apply(((wins == N), String.Format("Alice and Bob's quantum strategy is not optimal: win rate {0}", (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / MicrosoftQuantumConvertIntAsDouble.Apply(N)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.PlayQuantumMagicSquare = this.Factory.Get<ICallable<(ICallable,ICallable), (IQArray<Int64>,IQArray<Int64>)>>(typeof(PlayQuantumMagicSquare));
            this.QuantumRunner = this.Factory.Get<ICallable<(ICallable,Int64,Int64), (IQArray<Int64>,IQArray<Int64>)>>(typeof(QuantumRunner));
            this.RunTrials = this.Factory.Get<ICallable<(Int64,ICallable), Int64>>(typeof(RunTrials));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T27_PlayQuantumMagicSquare_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class DrawMagicSquare : Function<(IQArray<Int64>,Int64,IQArray<Int64>,Int64), QVoid>, ICallable
    {
        public DrawMagicSquare(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,Int64,IQArray<Int64>,Int64)>, IApplyData
        {
            public In((IQArray<Int64>,Int64,IQArray<Int64>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "DrawMagicSquare";
        String ICallable.FullName => "Quantum.Kata.MagicSquareGame.DrawMagicSquare";
        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,Int64,IQArray<Int64>,Int64), QVoid> Body => (__in__) =>
        {
            var (alice,row,bob,column) = __in__;
#line 283 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            foreach (var i in new Range(0L, 2L))
#line hidden
            {
#line 284 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                var line = QArray<String>.Create(3L);
#line 285 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                foreach (var j in new Range(0L, 2L))
#line hidden
                {
#line 286 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                    if ((((i == row) && (j == column)) && (alice[j] != bob[i])))
                    {
#line 287 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        line.Modify(j, "±");
                    }
                    else if ((i == row))
                    {
#line 289 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        line.Modify(j, ((alice[j] == 1L) ? "+" : ((alice[j] == -(1L)) ? "-" : "?")));
                    }
                    else if ((j == column))
                    {
#line 291 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        line.Modify(j, ((bob[i] == 1L) ? "+" : ((bob[i] == -(1L)) ? "-" : "?")));
                    }
                    else
                    {
#line 293 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                        line.Modify(j, " ");
                    }
                }

#line 296 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumIntrinsicMessage.Apply("-------");
#line 297 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
                MicrosoftQuantumIntrinsicMessage.Apply(String.Format("|{0}|{1}|{2}|", line[0L], line[1L], line[2L]));
            }

#line 299 "G:\\量子实习\\quantumKatas-VS\\MagicSquareGame\\Tests.qs"
            MicrosoftQuantumIntrinsicMessage.Apply("-------");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __dataIn((IQArray<Int64>,Int64,IQArray<Int64>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> alice, Int64 row, IQArray<Int64> bob, Int64 column)
        {
            return __m__.Run<DrawMagicSquare, (IQArray<Int64>,Int64,IQArray<Int64>,Int64), QVoid>((alice, row, bob, column));
        }
    }
}