#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"SingleQubitMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"SingleQubitMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ParityMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ParityMeasurement_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrGHZWithX_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":38}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrGHZWithX_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"GHZOrWState_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":40,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DifferentBasis_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"DifferentBasis_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":49,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":67,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":69,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.JointMeasurements\",\"Name\":\"ControlledX_General_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/JointMeasurements/ReferenceImplementation.qs\",\"Position\":{\"Item1\":95,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.JointMeasurements
{
    public partial class SingleQubitMeasurement_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public SingleQubitMeasurement_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SingleQubitMeasurement_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.SingleQubitMeasurement_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 21 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumIntrinsicM.Apply(qs[0L]) == MicrosoftQuantumIntrinsicM.Apply(qs[1L])) ? 0L : 1L);
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
            return __m__.Run<SingleQubitMeasurement_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ParityMeasurement_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public ParityMeasurement_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ParityMeasurement_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ParityMeasurement_Reference";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 27 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qs)) == Result.Zero) ? 0L : 1L);
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
            return __m__.Run<ParityMeasurement_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrGHZWithX_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrGHZWithX_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrGHZWithX_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.GHZOrGHZWithX_Reference";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 36 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qs?.Slice(new Range(1L, 2L)))) == Result.Zero) ? 0L : 1L);
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
            return __m__.Run<GHZOrGHZWithX_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class GHZOrWState_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public GHZOrWState_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GHZOrWState_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.GHZOrWState_Reference";
        protected ICallable<IQArray<Qubit>, Result> MicrosoftQuantumCharacterizationMeasureAllZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 45 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumCharacterizationMeasureAllZ.Apply(qs) == Result.Zero) ? 0L : 1L);
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCharacterizationMeasureAllZ = this.Factory.Get<ICallable<IQArray<Qubit>, Result>>(typeof(Microsoft.Quantum.Characterization.MeasureAllZ));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<GHZOrWState_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class DifferentBasis_Reference : Operation<IQArray<Qubit>, Int64>, ICallable
    {
        public DifferentBasis_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "DifferentBasis_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.DifferentBasis_Reference";
        protected ICallable<(IQArray<Pauli>,IQArray<Qubit>), Result> MicrosoftQuantumIntrinsicMeasure
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, Int64> Body => (__in__) =>
        {
            var qs = __in__;
#line 54 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            return ((MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliX, Pauli.PauliX), qs)) == Result.Zero) ? 0L : 1L);
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
            return __m__.Run<DifferentBasis_Reference, IQArray<Qubit>, Int64>(qs);
        }
    }

    public partial class ControlledX_Reference : Operation<IQArray<Qubit>, QVoid>, ICallable
    {
        public ControlledX_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ControlledX_Reference";
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
#line 60 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[1L]);
#line 61 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
            if ((MicrosoftQuantumIntrinsicMeasure.Apply((new QArray<Pauli>(Pauli.PauliZ, Pauli.PauliZ), qs)) == Result.One))
            {
#line 62 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
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
            return __m__.Run<ControlledX_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class ControlledX_General_Reference : Adjointable<IQArray<Qubit>>, ICallable
    {
        public ControlledX_General_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "ControlledX_General_Reference";
        String ICallable.FullName => "Quantum.Kata.JointMeasurements.ControlledX_General_Reference";
        protected ICallable<IQArray<Qubit>, Result> MicrosoftQuantumCharacterizationMeasureAllZ
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

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line hidden
            {
#line 74 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                var a = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 75 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    var c = qs[0L];
#line 76 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    var t = qs[1L];
#line 77 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(a);
#line 78 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    var p1 = MicrosoftQuantumCharacterizationMeasureAllZ.Apply(new QArray<Qubit>(c, a));
#line 79 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(a);
#line 80 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(t);
#line 81 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    var p2 = MicrosoftQuantumCharacterizationMeasureAllZ.Apply(new QArray<Qubit>(a, t));
#line 82 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(a);
#line 83 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    MicrosoftQuantumIntrinsicH.Apply(t);
#line 84 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    var m = MicrosoftQuantumMeasurementMResetZ.Apply(a);
#line 87 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    if ((p2 == Result.One))
                    {
#line 88 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicZ.Apply(c);
                    }

#line 90 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                    if ((p1 != m))
                    {
#line 91 "G:\\量子实习\\quantumKatas-VS\\JointMeasurements\\ReferenceImplementation.qs"
                        MicrosoftQuantumIntrinsicX.Apply(t);
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
                    Release.Apply(a);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => Body;
        public override void Init()
        {
            this.MicrosoftQuantumCharacterizationMeasureAllZ = this.Factory.Get<ICallable<IQArray<Qubit>, Result>>(typeof(Microsoft.Quantum.Characterization.MeasureAllZ));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<ControlledX_General_Reference, IQArray<Qubit>, QVoid>(qs);
        }
    }
}