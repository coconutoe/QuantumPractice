#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"WinCondition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"WinCondition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":22,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceClassical_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceClassical_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobClassical_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobClassical_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.CHSHGame.CreateEntangledPair_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceQuantum_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceQuantum_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":51,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"RotateBobQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"clockwise\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"RotateBobQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobQuantum_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobQuantum_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"PlayQuantumCHSH_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"askAlice\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"askBob\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":42},\"Item2\":{\"Line\":2,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"PlayQuantumCHSH_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.CHSHGame
{
    public partial class WinCondition_Reference : Function<(Boolean,Boolean,Boolean,Boolean), Boolean>, ICallable
    {
        public WinCondition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Boolean,Boolean)>, IApplyData
        {
            public In((Boolean,Boolean,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "WinCondition_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.WinCondition_Reference";
        public override Func<(Boolean,Boolean,Boolean,Boolean), Boolean> Body => (__in__) =>
        {
            var (x,y,a,b) = __in__;
#line 24 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            return ((x && y) == (a != b));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Boolean,Boolean,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean x, Boolean y, Boolean a, Boolean b)
        {
            return __m__.Run<WinCondition_Reference, (Boolean,Boolean,Boolean,Boolean), Boolean>((x, y, a, b));
        }
    }

    public partial class AliceClassical_Reference : Function<Boolean, Boolean>, ICallable
    {
        public AliceClassical_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AliceClassical_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.AliceClassical_Reference";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var x = __in__;
#line 31 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            return false;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean x)
        {
            return __m__.Run<AliceClassical_Reference, Boolean, Boolean>(x);
        }
    }

    public partial class BobClassical_Reference : Function<Boolean, Boolean>, ICallable
    {
        public BobClassical_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BobClassical_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.BobClassical_Reference";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var y = __in__;
#line 35 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            return false;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean y)
        {
            return __m__.Run<BobClassical_Reference, Boolean, Boolean>(y);
        }
    }

    public partial class CreateEntangledPair_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public CreateEntangledPair_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CreateEntangledPair_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.CreateEntangledPair_Reference";
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
#line 46 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 47 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
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
            return __m__.Run<CreateEntangledPair_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class AliceQuantum_Reference : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public AliceQuantum_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "AliceQuantum_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.AliceQuantum_Reference";
        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Boolean> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 55 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            var basis = (bit ? Pauli.PauliX : Pauli.PauliZ);
#line 56 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            return MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(basis), new QArray<Qubit>(qubit))));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<AliceQuantum_Reference, (Boolean,Qubit), Boolean>((bit, qubit));
        }
    }

    public partial class RotateBobQubit_Reference : Operation<(Boolean,Qubit), QVoid>, ICallable
    {
        public RotateBobQubit_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "RotateBobQubit_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.RotateBobQubit_Reference";
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

        public override Func<(Boolean,Qubit), QVoid> Body => (__in__) =>
        {
            var (clockwise,qubit) = __in__;
#line 62 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            var angle = ((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 8D);
#line 63 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicRy.Apply(((clockwise ? -(angle) : angle), qubit));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Boolean clockwise, Qubit qubit)
        {
            return __m__.Run<RotateBobQubit_Reference, (Boolean,Qubit), QVoid>((clockwise, qubit));
        }
    }

    public partial class BobQuantum_Reference : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public BobQuantum_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Qubit) data) : base(data)
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

        String ICallable.Name => "BobQuantum_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.BobQuantum_Reference";
        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), QVoid> RotateBobQubit_Reference
        {
            get;
            set;
        }

        public override Func<(Boolean,Qubit), Boolean> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 69 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            RotateBobQubit_Reference.Apply((!(bit), qubit));
#line 70 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
            return MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicM.Apply(qubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.RotateBobQubit_Reference = this.Factory.Get<ICallable<(Boolean,Qubit), QVoid>>(typeof(RotateBobQubit_Reference));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<BobQuantum_Reference, (Boolean,Qubit), Boolean>((bit, qubit));
        }
    }

    public partial class PlayQuantumCHSH_Reference : Operation<(ICallable,ICallable), (Boolean,Boolean)>, ICallable
    {
        public PlayQuantumCHSH_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable)>, IApplyData
        {
            public In((ICallable,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        public class Out : QTuple<(Boolean,Boolean)>, IApplyData
        {
            public Out((Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PlayQuantumCHSH_Reference";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.PlayQuantumCHSH_Reference";
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

        protected IAdjointable<IQArray<Qubit>> CreateEntangledPair_Reference
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable), (Boolean,Boolean)> Body => (__in__) =>
        {
            var (askAlice,askBob) = __in__;
#line hidden
            {
#line 78 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                var (aliceQubit,bobQubit) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 79 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    CreateEntangledPair_Reference.Apply(new QArray<Qubit>(aliceQubit, bobQubit));
#line 81 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    var aliceResult = askAlice.Apply<Boolean>(aliceQubit);
#line 82 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    var bobResult = askBob.Apply<Boolean>(bobQubit);
#line 84 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(aliceQubit);
#line 85 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(bobQubit);
#line 86 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\ReferenceImplementation.qs"
                    return (aliceResult, bobResult);
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
                    Release.Apply(aliceQubit);
#line hidden
                    Release.Apply(bobQubit);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CreateEntangledPair_Reference));
        }

        public override IApplyData __dataIn((ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut((Boolean,Boolean) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, ICallable askAlice, ICallable askBob)
        {
            return __m__.Run<PlayQuantumCHSH_Reference, (ICallable,ICallable), (Boolean,Boolean)>((askAlice, askBob));
        }
    }
}