#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"WinCondition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"rst\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"abc\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"WinCondition\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":45,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RandomClassicalStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RandomClassicalStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"BestClassicalStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"BestClassicalStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":83,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayClassicalGHZ\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"strategy\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayClassicalGHZ\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"CreateEntangledTriple\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"CreateEntangledTriple\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":124,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"QuantumStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"QuantumStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":145,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayQuantumGHZ\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":164,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"strategies\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayQuantumGHZ\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tasks.qs\",\"Position\":{\"Item1\":164,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.GHZGame
{
    public partial class WinCondition : Function<(IQArray<Boolean>,IQArray<Boolean>), Boolean>, ICallable
    {
        public WinCondition(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "WinCondition";
        String ICallable.FullName => "Quantum.Kata.GHZGame.WinCondition";
        public override Func<(IQArray<Boolean>,IQArray<Boolean>), Boolean> Body => (__in__) =>
        {
            var (rst,abc) = __in__;
#line 50 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            var a = abc[0L];
#line 51 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            var b = abc[1L];
#line 52 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            var c = abc[2L];
#line 53 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            if (((!(rst[0L]) && !(rst[1L])) && !(rst[2L])))
            {
#line 54 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                if ((((((!(a) && !(b)) && !(c)) || ((a && b) && !(c))) || ((a && !(b)) && c)) || ((!(a) && b) && c)))
                {
#line 55 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return true;
                }
                else
                {
#line 57 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return false;
                }
            }
            else
            {
#line 60 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                if ((((((!(a) && !(b)) && c) || ((!(a) && b) && !(c))) || ((a && !(b)) && !(c))) || ((a && b) && c)))
                {
#line 61 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return true;
                }
                else
                {
#line 63 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return false;
                }
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, IQArray<Boolean> rst, IQArray<Boolean> abc)
        {
            return __m__.Run<WinCondition, (IQArray<Boolean>,IQArray<Boolean>), Boolean>((rst, abc));
        }
    }

    public partial class RandomClassicalStrategy : Operation<Boolean, Boolean>, ICallable
    {
        public RandomClassicalStrategy(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomClassicalStrategy";
        String ICallable.FullName => "Quantum.Kata.GHZGame.RandomClassicalStrategy";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var input = __in__;
#line 74 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            var randNum = MicrosoftQuantumMathRandomInt.Apply(2L);
#line 75 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            return (randNum == 0L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean input)
        {
            return __m__.Run<RandomClassicalStrategy, Boolean, Boolean>(input);
        }
    }

    public partial class BestClassicalStrategy : Operation<Boolean, Boolean>, ICallable
    {
        public BestClassicalStrategy(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BestClassicalStrategy";
        String ICallable.FullName => "Quantum.Kata.GHZGame.BestClassicalStrategy";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var input = __in__;
#line 85 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            return true;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Boolean data) => new QTuple<Boolean>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean input)
        {
            return __m__.Run<BestClassicalStrategy, Boolean, Boolean>(input);
        }
    }

    public partial class PlayClassicalGHZ : Operation<(ICallable,IQArray<Boolean>), IQArray<Boolean>>, ICallable
    {
        public PlayClassicalGHZ(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IQArray<Boolean>)>, IApplyData
        {
            public In((ICallable,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "PlayClassicalGHZ";
        String ICallable.FullName => "Quantum.Kata.GHZGame.PlayClassicalGHZ";
        public override Func<(ICallable,IQArray<Boolean>), IQArray<Boolean>> Body => (__in__) =>
        {
            var (strategy,inputs) = __in__;
#line 97 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            if (!(strategy.Apply<Boolean>(false)))
            {
#line 98 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                if (strategy.Apply<Boolean>(true))
                {
#line 99 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return inputs;
                }
                else
                {
#line 101 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return new QArray<Boolean>(false, false, false);
                }
            }
            else
            {
#line 104 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                if (strategy.Apply<Boolean>(true))
                {
#line 105 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return new QArray<Boolean>(true, true, true);
                }
                else
                {
#line 107 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return new QArray<Boolean>(!(inputs[0L]), !(inputs[1L]), !(inputs[2L]));
                }
            }
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, ICallable strategy, IQArray<Boolean> inputs)
        {
            return __m__.Run<PlayClassicalGHZ, (ICallable,IQArray<Boolean>), IQArray<Boolean>>((strategy, inputs));
        }
    }

    public partial class CreateEntangledTriple : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public CreateEntangledTriple(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CreateEntangledTriple";
        String ICallable.FullName => "Quantum.Kata.GHZGame.CreateEntangledTriple";
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

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 126 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicX.Apply(qs[2L]);
#line 127 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 128 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 129 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[0L], qs[2L]));
#line 130 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[1L], qs[2L]));
#line 131 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicZ.Apply(qs[2L]);
#line 132 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 133 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 134 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[2L], qs[1L]));
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

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<CreateEntangledTriple, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class QuantumStrategy : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public QuantumStrategy(IOperationFactory m) : base(m)
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

        String ICallable.Name => "QuantumStrategy";
        String ICallable.FullName => "Quantum.Kata.GHZGame.QuantumStrategy";
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
            var (input,qubit) = __in__;
#line 147 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            var res = false;
#line 148 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            if (!(input))
            {
#line 149 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                res = (MicrosoftQuantumIntrinsicM.Apply(qubit) == Result.One);
            }
            else
            {
#line 151 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                MicrosoftQuantumIntrinsicRy.Apply(((MicrosoftQuantumMathPI.Apply(QVoid.Instance) / -(2D)), qubit));
#line 152 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                res = (MicrosoftQuantumIntrinsicM.Apply(qubit) == Result.One);
            }

#line 154 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
            return res;
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
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean input, Qubit qubit)
        {
            return __m__.Run<QuantumStrategy, (Boolean,Qubit), Boolean>((input, qubit));
        }
    }

    public partial class PlayQuantumGHZ : Operation<IQArray<ICallable>, IQArray<Boolean>>, ICallable
    {
        public PlayQuantumGHZ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PlayQuantumGHZ";
        String ICallable.FullName => "Quantum.Kata.GHZGame.PlayQuantumGHZ";
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

        protected ICallable<IQArray<Qubit>, QVoid> CreateEntangledTriple
        {
            get;
            set;
        }

        public override Func<IQArray<ICallable>, IQArray<Boolean>> Body => (__in__) =>
        {
            var strategies = __in__;
#line hidden
            {
#line 166 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 167 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    CreateEntangledTriple.Apply(qs);
#line 168 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    var ret_abc = (IQArray<Boolean>)new QArray<Boolean>(strategies[0L].Apply<Boolean>(qs[0L]), strategies[1L].Apply<Boolean>(qs[1L]), strategies[2L].Apply<Boolean>(qs[2L]));
#line 169 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
#line 171 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tasks.qs"
                    return ret_abc;
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
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicResetAll = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.ResetAll));
            this.CreateEntangledTriple = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(CreateEntangledTriple));
        }

        public override IApplyData __dataIn(IQArray<ICallable> data) => data;
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, IQArray<ICallable> strategies)
        {
            return __m__.Run<PlayQuantumGHZ, IQArray<ICallable>, IQArray<Boolean>>(strategies);
        }
    }
}