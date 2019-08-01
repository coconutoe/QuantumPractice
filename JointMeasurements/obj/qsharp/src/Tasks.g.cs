#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"SingleQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"SingleQubitMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ParityMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ParityMeasurement\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":46,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrGHZWithX\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":28}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrGHZWithX\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrWState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DifferentBasis\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":29}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DifferentBasis\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":26}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":123,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":125,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/Tasks.qs\",\"Position\":{\"Item1\":130,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.JointMeasurements
{
    public partial class SingleQubitMeasurement : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public SingleQubitMeasurement(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SingleQubitMeasurement";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.SingleQubitMeasurement";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 34 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res1 = MicrosoftQuantumIntrinsicM.Apply(qs[0L]);
#line 35 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res2 = MicrosoftQuantumIntrinsicM.Apply(qs[1L]);
#line 36 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            return ((res1 == res2) ? 0L : 1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<SingleQubitMeasurement, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ParityMeasurement : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ParityMeasurement(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ParityMeasurement";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ParityMeasurement";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 48 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), new QArray<Qubit>(qs[0L], qs[1L])));
#line 49 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var ret = ((res == Result.Zero) ? 0L : 1L);
#line 51 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            return ret;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ParityMeasurement, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrGHZWithX : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrGHZWithX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrGHZWithX";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.GHZOrGHZWithX";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 63 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliI, Pauli.PauliZ, Pauli.PauliI, Pauli.PauliZ), new QArray<Qubit>(qs[0L], qs[1L], qs[2L], qs[3L])));
#line 64 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var ret = ((res == Result.Zero) ? 0L : 1L);
#line 65 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            return ret;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<GHZOrGHZWithX, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrWState : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrWState(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrWState";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.GHZOrWState";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 77 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var N = qs.Length;
#line 78 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var pauliArr = new QArray<Pauli>(Pauli.PauliZ);
#line 80 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            foreach (var i in new Range(1L, (N - 1L)))
#line hidden
            {
#line 81 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
                pauliArr = QArray<Pauli>.Add(pauliArr, new QArray<Pauli>(Pauli.PauliZ));
            }

#line 83 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res = MicrosoftQuantumIntrinsicMeasure.Apply((pauliArr?.Copy(), qs));
#line 84 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var ret = ((res == Result.Zero) ? 0L : 1L);
#line 85 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            return ret;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<GHZOrWState, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class DifferentBasis : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public DifferentBasis(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DifferentBasis";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.DifferentBasis";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 97 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX), qs));
#line 98 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var ret = ((res == Result.Zero) ? 0L : 1L);
#line 99 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            return ret;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<DifferentBasis, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ControlledX : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ControlledX(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ControlledX";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 111 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 112 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            var res = MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qs));
#line 113 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
            if ((res == Result.One))
            {
#line 114 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qs[1L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicMeasure = this.Factory.Get<ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result>>(typeof(Microsoft.Quantum.Intrinsic.Measure));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ControlledX, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ControlledX_General : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ControlledX_General(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX_General";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ControlledX_General";
        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ControlledX_General, IQArray<Qubit>, QVoid>(qs);
        }
    }
}