#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Eigenstates_ZST_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Eigenstates_ZST_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Eigenstates_ZST_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":27,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.PhaseEstimation.Eigenstates_ZST_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPowerImpl_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":78}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":87}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPowerImpl_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPowerImpl_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.PhaseEstimation.UnitaryPowerImpl_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPowerImpl_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.PhaseEstimation.UnitaryPowerImpl_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPowerImpl_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.PhaseEstimation.UnitaryPowerImpl_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPower_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":73}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"UnitaryPower_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"AssertIsEigenstate_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"AssertIsEigenstate_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Oracle_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"power\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":82}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Oracle_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Oracle_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.PhaseEstimation.Oracle_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Oracle_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlled specialization for Quantum.Kata.PhaseEstimation.Oracle_Reference\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"Oracle_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":17}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for Quantum.Kata.PhaseEstimation.Oracle_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"QPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":89}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Double\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"QPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"SingleBitPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"SingleBitPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"TwoBitPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":117,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"U\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"P\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.PhaseEstimation\",\"Name\":\"TwoBitPE_Reference\"},\"SourceFile\":\"G:/QuantumPractice/quantumKatas-VS/PhaseEstimation/ReferenceImplementation.qs\",\"Position\":{\"Item1\":117,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.PhaseEstimation
{
    public partial class Eigenstates_ZST_Reference : Adjointable<(Qubit,Int64)>, ICallable
    {
        public Eigenstates_ZST_Reference(IOperationFactory m) : base(m)
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

        String ICallable.Name => "Eigenstates_ZST_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.Eigenstates_ZST_Reference";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Qubit,Int64), QVoid> Body => (__in__) =>
        {
            var (q,state) = __in__;
#line 31 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
            if ((state == 1L))
            {
#line 32 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (q,state) = __in__;
#line hidden
            if ((state == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicX.Adjoint.Apply(q);
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
            return __m__.Run<Eigenstates_ZST_Reference, (Qubit,Int64), QVoid>((q, state));
        }
    }

    public partial class UnitaryPowerImpl_Reference : Unitary<(IUnitary,Int64,Qubit)>, ICallable
    {
        public UnitaryPowerImpl_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,Qubit)>, IApplyData
        {
            public In((IUnitary,Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "UnitaryPowerImpl_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.UnitaryPowerImpl_Reference";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64,Qubit), QVoid> Body => (__in__) =>
        {
            var (U,power,q) = __in__;
#line 40 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line 41 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                U.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Int64,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (U,power,q) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                U.Adjoint.Apply(q);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,Int64,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(U,power,q)) = __in__;
#line hidden
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line hidden
                U.Controlled.Apply((__controlQubits__, q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,Int64,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(U,power,q)) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                U.Adjoint.Controlled.Apply((__controlQubits__, q));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IUnitary,Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary U, Int64 power, Qubit q)
        {
            return __m__.Run<UnitaryPowerImpl_Reference, (IUnitary,Int64,Qubit), QVoid>((U, power, q));
        }
    }

    public partial class UnitaryPower_Reference : Function<(IUnitary,Int64), IUnitary>, ICallable
    {
        public UnitaryPower_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64)>, IApplyData
        {
            public In((IUnitary,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "UnitaryPower_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.UnitaryPower_Reference";
        protected IUnitary<(IUnitary,Int64,Qubit)> UnitaryPowerImpl_Reference
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64), IUnitary> Body => (__in__) =>
        {
            var (U,power) = __in__;
#line 47 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
            return UnitaryPowerImpl_Reference.Partial(new Func<Qubit, (IUnitary,Int64,Qubit)>((__arg1__) => (U, power, __arg1__)));
        }

        ;
        public override void Init()
        {
            this.UnitaryPowerImpl_Reference = this.Factory.Get<IUnitary<(IUnitary,Int64,Qubit)>>(typeof(UnitaryPowerImpl_Reference));
        }

        public override IApplyData __dataIn((IUnitary,Int64) data) => new In(data);
        public override IApplyData __dataOut(IUnitary data) => new QTuple<IUnitary>(data);
        public static System.Threading.Tasks.Task<IUnitary> Run(IOperationFactory __m__, IUnitary U, Int64 power)
        {
            return __m__.Run<UnitaryPower_Reference, (IUnitary,Int64), IUnitary>((U, power));
        }
    }

    public partial class AssertIsEigenstate_Reference : Operation<(ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertIsEigenstate_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IAdjointable)>, IApplyData
        {
            public In((ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AssertIsEigenstate_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.AssertIsEigenstate_Reference";
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
            var (U,P) = __in__;
#line hidden
            {
#line 54 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 56 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Apply(q);
#line 58 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    U.Apply(q);
#line 61 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Adjoint.Apply(q);
#line 62 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable U, IAdjointable P)
        {
            return __m__.Run<AssertIsEigenstate_Reference, (ICallable,IAdjointable), QVoid>((U, P));
        }
    }

    public partial class Oracle_Reference : Unitary<(IUnitary,Int64,IQArray<Qubit>)>, ICallable
    {
        public Oracle_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,Int64,IQArray<Qubit>)>, IApplyData
        {
            public In((IUnitary,Int64,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Oracle_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.Oracle_Reference";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IUnitary,Int64,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (U,power,target) = __in__;
#line 70 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line 71 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                U.Apply(target[0L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IUnitary,Int64,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (U,power,target) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                U.Adjoint.Apply(target[0L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,Int64,IQArray<Qubit>)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(U,power,target)) = __in__;
#line hidden
            foreach (var i in new Range(1L, power))
#line hidden
            {
#line hidden
                U.Controlled.Apply((__controlQubits__, target[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IUnitary,Int64,IQArray<Qubit>)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(U,power,target)) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, power)))
#line hidden
            {
#line hidden
                U.Adjoint.Controlled.Apply((__controlQubits__, target[0L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IUnitary,Int64,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IUnitary U, Int64 power, IQArray<Qubit> target)
        {
            return __m__.Run<Oracle_Reference, (IUnitary,Int64,IQArray<Qubit>), QVoid>((U, power, target));
        }
    }

    public partial class QPE_Reference : Operation<(IUnitary,IAdjointable,Int64), Double>, ICallable
    {
        public QPE_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IAdjointable,Int64)>, IApplyData
        {
            public In((IUnitary,IAdjointable,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QPE_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.QPE_Reference";
        protected ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian> MicrosoftQuantumArithmeticBigEndian
        {
            get;
            set;
        }

        protected ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Int64> MicrosoftQuantumCanonMeasureIntegerBE
        {
            get;
            set;
        }

        protected IUnitary<(Microsoft.Quantum.Oracles.DiscreteOracle,IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)> MicrosoftQuantumCharacterizationQuantumPhaseEstimation
        {
            get;
            set;
        }

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

        protected ICallable<IUnitary, Microsoft.Quantum.Oracles.DiscreteOracle> MicrosoftQuantumOraclesDiscreteOracle
        {
            get;
            set;
        }

        protected IUnitary<(IUnitary,Int64,IQArray<Qubit>)> Oracle_Reference
        {
            get;
            set;
        }

        public override Func<(IUnitary,IAdjointable,Int64), Double> Body => (__in__) =>
        {
            var (U,P,n) = __in__;
#line 78 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
            var oracle = new Microsoft.Quantum.Oracles.DiscreteOracle(Oracle_Reference.Partial(new Func<(Int64,IQArray<Qubit>), (IUnitary,Int64,IQArray<Qubit>)>((__arg1__) => (U, __arg1__.Item1, __arg1__.Item2))));
#line hidden
            {
#line 80 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                var (eigenstate,phaseRegister) = (Allocate.Apply(1L), Allocate.Apply(n));
#line hidden
                Exception __arg2__ = null;
                try
                {
#line 81 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var phaseRegisterBE = new Microsoft.Quantum.Arithmetic.BigEndian(phaseRegister);
#line 83 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Apply(eigenstate[0L]);
#line 85 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumCharacterizationQuantumPhaseEstimation.Apply((oracle, eigenstate, phaseRegisterBE));
#line 87 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var phase = (MicrosoftQuantumConvertIntAsDouble.Apply(MicrosoftQuantumCanonMeasureIntegerBE.Apply(phaseRegisterBE)) / MicrosoftQuantumConvertIntAsDouble.Apply((1L << (int)n)));
#line 89 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(eigenstate);
#line 90 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(phaseRegister);
#line 91 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    return phase;
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
                    Release.Apply(eigenstate);
#line hidden
                    Release.Apply(phaseRegister);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArithmeticBigEndian = this.Factory.Get<ICallable<IQArray<Qubit>, Microsoft.Quantum.Arithmetic.BigEndian>>(typeof(Microsoft.Quantum.Arithmetic.BigEndian));
            this.MicrosoftQuantumCanonMeasureIntegerBE = this.Factory.Get<ICallable<Microsoft.Quantum.Arithmetic.BigEndian, Int64>>(typeof(Microsoft.Quantum.Canon.MeasureIntegerBE));
            this.MicrosoftQuantumCharacterizationQuantumPhaseEstimation = this.Factory.Get<IUnitary<(Microsoft.Quantum.Oracles.DiscreteOracle,IQArray<Qubit>,Microsoft.Quantum.Arithmetic.BigEndian)>>(typeof(Microsoft.Quantum.Characterization.QuantumPhaseEstimation));
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.MicrosoftQuantumOraclesDiscreteOracle = this.Factory.Get<ICallable<IUnitary, Microsoft.Quantum.Oracles.DiscreteOracle>>(typeof(Microsoft.Quantum.Oracles.DiscreteOracle));
            this.Oracle_Reference = this.Factory.Get<IUnitary<(IUnitary,Int64,IQArray<Qubit>)>>(typeof(Oracle_Reference));
        }

        public override IApplyData __dataIn((IUnitary,IAdjointable,Int64) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, IUnitary U, IAdjointable P, Int64 n)
        {
            return __m__.Run<QPE_Reference, (IUnitary,IAdjointable,Int64), Double>((U, P, n));
        }
    }

    public partial class SingleBitPE_Reference : Operation<(IUnitary,IAdjointable), Int64>, ICallable
    {
        public SingleBitPE_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IAdjointable)>, IApplyData
        {
            public In((IUnitary,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SingleBitPE_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.SingleBitPE_Reference";
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

        protected ICallable<IQArray<Qubit>, QVoid> MicrosoftQuantumIntrinsicResetAll
        {
            get;
            set;
        }

        public override Func<(IUnitary,IAdjointable), Int64> Body => (__in__) =>
        {
            var (U,P) = __in__;
#line hidden
            {
#line 102 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                var (control,eigenstate) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 104 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Apply(eigenstate);
#line 106 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(control);
#line 107 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    U.Controlled.Apply((new QArray<Qubit>(control), eigenstate));
#line 108 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(control);
#line 110 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var eigenvalue = ((MicrosoftQuantumIntrinsicM.Apply(control) == Result.Zero) ? 1L : -(1L));
#line 111 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(new QArray<Qubit>(control, eigenstate));
#line 112 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    return eigenvalue;
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
                    Release.Apply(control);
#line hidden
                    Release.Apply(eigenstate);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __dataIn((IUnitary,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IUnitary U, IAdjointable P)
        {
            return __m__.Run<SingleBitPE_Reference, (IUnitary,IAdjointable), Int64>((U, P));
        }
    }

    public partial class TwoBitPE_Reference : Operation<(IUnitary,IAdjointable), Double>, ICallable
    {
        public TwoBitPE_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IUnitary,IAdjointable)>, IApplyData
        {
            public In((IUnitary,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TwoBitPE_Reference";
        String ICallable.FullName => "Quantum.Kata.PhaseEstimation.TwoBitPE_Reference";
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<(IUnitary,IAdjointable), Double> Body => (__in__) =>
        {
            var (U,P) = __in__;
#line hidden
            {
#line 123 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                var (control,eigenstate) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 125 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Apply(eigenstate);
#line 127 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var (measuredZero,measuredOne) = (false, false);
#line 128 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var iter = 0L;
#line 129 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    while (true)
                    {
#line 130 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        iter = (iter + 1L);
#line 132 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicH.Apply(control);
#line 133 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        U.Controlled.Apply((new QArray<Qubit>(control), eigenstate));
#line 134 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicH.Apply(control);
#line 136 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        var meas = MicrosoftQuantumMeasurementMResetZ.Apply(control);
#line 137 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        (measuredZero, measuredOne) = ((measuredZero || (meas == Result.Zero)), (measuredOne || (meas == Result.One)));
                        if (((iter == 10L) || (measuredZero && measuredOne)))
                        {
                            break;
                        }
                        else
                        {
                        }
                    }

#line 142 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(eigenstate);
#line 146 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    if ((!(measuredZero) || !(measuredOne)))
                    {
#line 147 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                        return (measuredOne ? 0.5D : 0D);
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
                    Release.Apply(control);
#line hidden
                    Release.Apply(eigenstate);
                }
            }

#line hidden
            {
#line 152 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                var (control,eigenstate) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg3__ = null;
                try
                {
#line 154 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    P.Apply(eigenstate);
#line 156 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(control);
#line 157 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    U.Controlled.Apply((new QArray<Qubit>(control), eigenstate));
#line 158 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicS.Apply(control);
#line 159 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(control);
#line 161 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    var eigenvalue = ((MicrosoftQuantumMeasurementMResetZ.Apply(control) == Result.Zero) ? 0.75D : 0.25D);
#line 162 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(eigenstate);
#line 163 "G:\\QuantumPractice\\quantumKatas-VS\\PhaseEstimation\\ReferenceImplementation.qs"
                    return eigenvalue;
                }
#line hidden
                catch (Exception __arg4__)
                {
                    __arg3__ = __arg4__;
                    throw __arg3__;
                }
#line hidden
                finally
                {
                    if (__arg3__ != null)
                    {
                        throw __arg3__;
                    }

#line hidden
                    Release.Apply(control);
#line hidden
                    Release.Apply(eigenstate);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn((IUnitary,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, IUnitary U, IAdjointable P)
        {
            return __m__.Run<TwoBitPE_Reference, (IUnitary,IAdjointable), Double>((U, P));
        }
    }
}