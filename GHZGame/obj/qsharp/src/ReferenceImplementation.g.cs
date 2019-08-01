#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"WinCondition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"rst\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"abc\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"WinCondition_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RandomClassicalStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RandomClassicalStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":30,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"BestClassicalStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Bool\"},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"BestClassicalStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayClassicalGHZ_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"strategy\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayClassicalGHZ_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"CreateEntangledTriple_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"CreateEntangledTriple_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"CreateEntangledTriple_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":53,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GHZGame.CreateEntangledTriple_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"QuantumStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"QuantumStrategy_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":72,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayQuantumGHZ_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":81,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"strategies\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"PlayQuantumGHZ_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/ReferenceImplementation.qs\",\"Position\":{\"Item1\":81,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.GHZGame
{
    public partial class WinCondition_Reference : Function<(IQArray<Boolean>,IQArray<Boolean>), Boolean>, ICallable
    {
        public WinCondition_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "WinCondition_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.WinCondition_Reference";
        protected ICallable<(Boolean,Boolean), Boolean> MicrosoftQuantumCanonXOR
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>), Boolean> Body => (__in__) =>
        {
            var (rst,abc) = __in__;
#line 26 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            return (((rst[0L] || rst[1L]) || rst[2L]) == MicrosoftQuantumCanonXOR.Apply((MicrosoftQuantumCanonXOR.Apply((abc[0L], abc[1L])), abc[2L])));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonXOR = this.Factory.Get<ICallable<(Boolean,Boolean), Boolean>>(typeof(Microsoft.Quantum.Canon.XOR));
        }

        public override IApplyData __dataIn((IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, IQArray<Boolean> rst, IQArray<Boolean> abc)
        {
            return __m__.Run<WinCondition_Reference, (IQArray<Boolean>,IQArray<Boolean>), Boolean>((rst, abc));
        }
    }

    public partial class RandomClassicalStrategy_Reference : Operation<Boolean, Boolean>, ICallable
    {
        public RandomClassicalStrategy_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomClassicalStrategy_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.RandomClassicalStrategy_Reference";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var input = __in__;
#line 32 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            return (MicrosoftQuantumMathRandomInt.Apply(2L) == 1L);
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
            return __m__.Run<RandomClassicalStrategy_Reference, Boolean, Boolean>(input);
        }
    }

    public partial class BestClassicalStrategy_Reference : Operation<Boolean, Boolean>, ICallable
    {
        public BestClassicalStrategy_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "BestClassicalStrategy_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.BestClassicalStrategy_Reference";
        public override Func<Boolean, Boolean> Body => (__in__) =>
        {
            var input = __in__;
#line 39 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
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
            return __m__.Run<BestClassicalStrategy_Reference, Boolean, Boolean>(input);
        }
    }

    public partial class PlayClassicalGHZ_Reference : Operation<(ICallable,IQArray<Boolean>), IQArray<Boolean>>, ICallable
    {
        public PlayClassicalGHZ_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IQArray<Boolean>)>, IApplyData
        {
            public In((ICallable,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "PlayClassicalGHZ_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.PlayClassicalGHZ_Reference";
        protected ICallable MicrosoftQuantumArraysForEach
        {
            get;
            set;
        }

        public override Func<(ICallable,IQArray<Boolean>), IQArray<Boolean>> Body => (__in__) =>
        {
            var (strategy,inputs) = __in__;
#line 45 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            return MicrosoftQuantumArraysForEach.Apply<IQArray<Boolean>>((strategy, inputs));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysForEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.ForEach<,>));
        }

        public override IApplyData __dataIn((ICallable,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, ICallable strategy, IQArray<Boolean> inputs)
        {
            return __m__.Run<PlayClassicalGHZ_Reference, (ICallable,IQArray<Boolean>), IQArray<Boolean>>((strategy, inputs));
        }
    }

    public partial class CreateEntangledTriple_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public CreateEntangledTriple_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "CreateEntangledTriple_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.CreateEntangledTriple_Reference";
        protected ICallable MicrosoftQuantumCanonControlledOnBitString
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
#line 56 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicX.Apply(qs[0L]);
#line 57 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
#line 59 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[0L]);
#line 60 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 64 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicZ.Controlled.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line 67 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumIntrinsicX)).Apply((new QArray<Qubit>(qs[0L], qs[1L]), qs[2L]));
#line 68 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumIntrinsicX)).Apply((new QArray<Qubit>(qs[0L], qs[1L]), qs[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(true, false), MicrosoftQuantumIntrinsicX)).Adjoint.Apply((new QArray<Qubit>(qs[0L], qs[1L]), qs[2L]));
#line hidden
            MicrosoftQuantumCanonControlledOnBitString.Apply<IUnitary>((new QArray<Boolean>(false, true), MicrosoftQuantumIntrinsicX)).Adjoint.Apply((new QArray<Qubit>(qs[0L], qs[1L]), qs[2L]));
#line hidden
            MicrosoftQuantumIntrinsicZ.Controlled.Adjoint.Apply((new QArray<Qubit>(qs[0L]), qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[1L]);
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[0L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[1L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonControlledOnBitString = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ControlledOnBitString<>));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<CreateEntangledTriple_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class QuantumStrategy_Reference : Operation<(Boolean,Qubit), Boolean>, ICallable
    {
        public QuantumStrategy_Reference(IOperationFactory m) : base(m)
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

        String ICallable.Name => "QuantumStrategy_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.QuantumStrategy_Reference";
        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
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

        public override Func<(Boolean,Qubit), Boolean> Body => (__in__) =>
        {
            var (input,qubit) = __in__;
#line 74 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            if (input)
            {
#line 75 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicH.Apply(qubit);
            }

#line 77 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
            return MicrosoftQuantumConvertResultAsBool.Apply(MicrosoftQuantumIntrinsicM.Apply(qubit));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn((Boolean,Qubit) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean input, Qubit qubit)
        {
            return __m__.Run<QuantumStrategy_Reference, (Boolean,Qubit), Boolean>((input, qubit));
        }
    }

    public partial class PlayQuantumGHZ_Reference : Operation<IQArray<ICallable>, IQArray<Boolean>>, ICallable
    {
        public PlayQuantumGHZ_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PlayQuantumGHZ_Reference";
        String ICallable.FullName => "Quantum.Kata.GHZGame.PlayQuantumGHZ_Reference";
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

        protected IAdjointable<IQArray<Qubit>> CreateEntangledTriple_Reference
        {
            get;
            set;
        }

        public override Func<IQArray<ICallable>, IQArray<Boolean>> Body => (__in__) =>
        {
            var strategies = __in__;
#line hidden
            {
#line 84 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                var qs = Allocate.Apply(3L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 85 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                    CreateEntangledTriple_Reference.Apply(qs);
#line 87 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                    var abc = QArray<Boolean>.Create(3L);
#line 88 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                    foreach (var i in new Range(0L, 2L))
#line hidden
                    {
#line 89 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                        abc.Modify(i, strategies[i].Apply<Boolean>(qs[i]));
                    }

#line 92 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicResetAll.Apply(qs);
#line 93 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\ReferenceImplementation.qs"
                    return abc;
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
            this.CreateEntangledTriple_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CreateEntangledTriple_Reference));
        }

        public override IApplyData __dataIn(IQArray<ICallable> data) => data;
        public override IApplyData __dataOut(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, IQArray<ICallable> strategies)
        {
            return __m__.Run<PlayQuantumGHZ_Reference, IQArray<ICallable>, IQArray<Boolean>>(strategies);
        }
    }
}