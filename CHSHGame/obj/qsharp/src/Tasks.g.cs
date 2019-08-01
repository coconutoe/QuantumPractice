#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"WinCondition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"WinCondition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceClassical\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceClassical\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":60,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobClassical\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobClassical\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":66,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"CreateEntangledPair\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"CreateEntangledPair\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceQuantum\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AliceQuantum\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":99,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"RotateBobQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"clockwise\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"RotateBobQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":116,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobQuantum\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bit\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"BobQuantum\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":135,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"PlayQuantumCHSH\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":152,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"askAlice\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"askBob\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"PlayQuantumCHSH\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tasks.qs\",\"Position\":{\"Item1\":152,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.CHSHGame
{
    public partial class WinCondition : Function<(Boolean,Boolean,Boolean,Boolean), Boolean>, ICallable
    {
        public WinCondition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Boolean,Boolean)>, IApplyData
        {
            public In((Boolean,Boolean,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "WinCondition";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.WinCondition";
        public override Func<(Boolean,Boolean,Boolean,Boolean), Boolean> Body => (__in__) =>
        {
            var (x,y,a,b) = __in__;
#line 41 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            if ((x && y))
            {
#line 42 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                if (((a && !(b)) || (!(a) && b)))
                {
#line 43 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                    return true;
                }

#line 45 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                return false;
            }
            else
            {
#line 47 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                if (((a && b) || (!(a) && !(b))))
                {
#line 48 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                    return true;
                }

#line 50 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                return false;
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Boolean,Boolean,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean x, Boolean y, Boolean a, Boolean b)
        {
            return __m__.Run<WinCondition, (Boolean,Boolean,Boolean,Boolean), Boolean>((x, y, a, b));
        }
    }

    public partial class AliceClassical : Operation<Boolean, Boolean>, ICallable
    {
        public AliceClassical(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "AliceClassical";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.AliceClassical";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var x = __in__;
#line 62 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            return x;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean x)
        {
            return __m__.Run<AliceClassical, Boolean, Boolean>(x);
        }
    }

    public partial class BobClassical : Operation<Boolean, Boolean>, ICallable
    {
        public BobClassical(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BobClassical";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.BobClassical";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var y = __in__;
#line 68 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
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
            return __m__.Run<BobClassical, Boolean, Boolean>(y);
        }
    }

    public partial class CreateEntangledPair : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public CreateEntangledPair(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CreateEntangledPair";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.CreateEntangledPair";
        protected ICallable Length
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

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 86 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 2L, "The array should have exactly 2 qubits."));
#line 88 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 89 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<CreateEntangledPair, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class AliceQuantum : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public AliceQuantum(IOperationFactory m) : base(m)
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

        String ICallable.Name => "AliceQuantum";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.AliceQuantum";
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

        public override Func<(Boolean,Qubit), Boolean> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 102 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            if (!(bit))
            {
#line 103 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                var res = MicrosoftQuantumIntrinsicM.Apply(qubit);
#line 104 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                return (res == Result.One);
            }
            else
            {
#line 106 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                var res = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliX), new QArray<Qubit>(qubit)));
#line 107 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                return (res == Result.One);
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<AliceQuantum, (Boolean,Qubit), Boolean>((bit, qubit));
        }
    }

    public partial class RotateBobQubit : Operation<(Boolean,Qubit), QVoid>, ICallable
    {
        public RotateBobQubit(IOperationFactory m) : base(m)
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

        String ICallable.Name => "RotateBobQubit";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.RotateBobQubit";
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
#line 120 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            if (clockwise)
            {
#line 121 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / -(4D)), qubit));
            }
            else
            {
#line 123 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 4D), qubit));
            }

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
            return __m__.Run<RotateBobQubit, (Boolean,Qubit), QVoid>((clockwise, qubit));
        }
    }

    public partial class BobQuantum : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public BobQuantum(IOperationFactory m) : base(m)
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

        String ICallable.Name => "BobQuantum";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.BobQuantum";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
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

        public override Func<(Boolean,Qubit), Boolean> Body => (__in__) =>
        {
            var (bit,qubit) = __in__;
#line 137 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            var theta = (bit ? (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / 4D) : (MicrosoftQuantumMathPI.Apply(QVoid.Instance) / -(4D)));
#line 139 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicRy.Apply((theta, qubit));
#line 140 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            var ret = MicrosoftQuantumIntrinsicM.Apply(qubit);
#line 141 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            return (ret == Result.One);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean bit, Qubit qubit)
        {
            return __m__.Run<BobQuantum, (Boolean,Qubit), Boolean>((bit, qubit));
        }
    }

    public partial class PlayQuantumCHSH : Operation<(ICallable,ICallable), (Boolean,Boolean)>, ICallable
    {
        public PlayQuantumCHSH(IOperationFactory m) : base(m)
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

        String ICallable.Name => "PlayQuantumCHSH";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.PlayQuantumCHSH";
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

        protected ICallable<IQArray<Qubit>, QVoid> CreateEntangledPair
        {
            get;
            set;
        }

        public override Func<(ICallable,ICallable), (Boolean,Boolean)> Body => (__in__) =>
        {
            var (askAlice,askBob) = __in__;
#line 155 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            var A_re = false;
#line 156 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            var B_re = false;
#line hidden
            {
#line 157 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 158 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                    CreateEntangledPair.Apply(qs);
#line 161 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                    A_re = askAlice.Apply<Boolean>(qs[0L]);
#line 162 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
                    B_re = askBob.Apply<Boolean>(qs[1L]);
#line 163 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
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

#line 166 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tasks.qs"
            return (A_re, B_re);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.CreateEntangledPair = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(CreateEntangledPair));
        }

        public override IApplyData __dataIn((ICallable,ICallable) data) => new In(data);
        public override IApplyData __dataOut((Boolean,Boolean) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, ICallable askAlice, ICallable askBob)
        {
            return __m__.Run<PlayQuantumCHSH, (ICallable,ICallable), (Boolean,Boolean)>((askAlice, askBob));
        }
    }
}