#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"QubitArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"QubitArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"QubitArrayWrapperOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":20,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":2,\"Column\":8},\"Item2\":{\"Line\":2,\"Column\":11}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.GroversAlgorithm.QubitArrayWrapperOperation\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"AssertRegisterOperationsEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"testOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":70},\"Item2\":{\"Line\":1,\"Column\":75}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"AssertRegisterOperationsEqual\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T11_Oracle_AllOnes_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T11_Oracle_AllOnes_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T12_Oracle_AlternatingBits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T12_Oracle_AlternatingBits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T13_Oracle_ArbitraryPattern_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T13_Oracle_ArbitraryPattern_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T14_OracleConverter_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T14_OracleConverter_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T21_HadamardTransform_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T21_HadamardTransform_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":75,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T22_ConditionalPhaseFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":81,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T22_ConditionalPhaseFlip_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":81,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T23_GroverIteration_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T23_GroverIteration_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":87,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T31_GroversSearch_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GroversAlgorithm\",\"Name\":\"T31_GroversSearch_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GroversAlgorithm/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.GroversAlgorithm
{
    public partial class QubitArrayWrapperOperation : Adjointable<(IAdjointable,IQArray<Qubit>)>, ICallable
    {
        public QubitArrayWrapperOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IQArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QubitArrayWrapperOperation";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.QubitArrayWrapperOperation";
        protected ICallable MicrosoftQuantumArraysMost
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumArraysTail
        {
            get;
            set;
        }

        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 23 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            op.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(qs), MicrosoftQuantumArraysTail.Apply<Qubit>(qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Adjoint.Apply((MicrosoftQuantumArraysMost.Apply<IQArray<Qubit>>(qs), MicrosoftQuantumArraysTail.Apply<Qubit>(qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumArraysMost = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Most<>));
            this.MicrosoftQuantumArraysTail = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Arrays.Tail<>));
        }

        public override IApplyData __dataIn((IAdjointable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, IQArray<Qubit> qs)
        {
            return __m__.Run<QubitArrayWrapperOperation, (IAdjointable,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class AssertRegisterOperationsEqual : Operation<(ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertRegisterOperationsEqual(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IAdjointable)>, IApplyData
        {
            public In((ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AssertRegisterOperationsEqual";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.AssertRegisterOperationsEqual";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        public override Func<(ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (testOp,refOp) = __in__;
#line 30 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            foreach (var n in new Range(2L, 10L))
#line hidden
            {
#line 31 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((n, testOp, refOp));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
        }

        public override IApplyData __dataIn((ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable testOp, IAdjointable refOp)
        {
            return __m__.Run<AssertRegisterOperationsEqual, (ICallable,IAdjointable), QVoid>((testOp, refOp));
        }
    }

    public partial class T11_Oracle_AllOnes_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_Oracle_AllOnes_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_Oracle_AllOnes_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T11_Oracle_AllOnes_Test";
        protected ICallable<(ICallable,IAdjointable), QVoid> AssertRegisterOperationsEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_AllOnes
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_AllOnes_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> QubitArrayWrapperOperation
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 38 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            var testOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (Oracle_AllOnes, __arg1__)));
#line 39 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            var refOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (Oracle_AllOnes_Reference, __arg2__)));
#line 40 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            AssertRegisterOperationsEqual.Apply((testOp, refOp));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertRegisterOperationsEqual = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertRegisterOperationsEqual));
            this.Oracle_AllOnes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_AllOnes));
            this.Oracle_AllOnes_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_AllOnes_Reference));
            this.QubitArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(QubitArrayWrapperOperation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_Oracle_AllOnes_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_Oracle_AlternatingBits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_Oracle_AlternatingBits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_Oracle_AlternatingBits_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T12_Oracle_AlternatingBits_Test";
        protected ICallable<(ICallable,IAdjointable), QVoid> AssertRegisterOperationsEqual
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_AlternatingBits
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit)> Oracle_AlternatingBits_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> QubitArrayWrapperOperation
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 46 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            var testOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (Oracle_AlternatingBits, __arg1__)));
#line 47 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            var refOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg2__) => (Oracle_AlternatingBits_Reference, __arg2__)));
#line 48 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            AssertRegisterOperationsEqual.Apply((testOp, refOp));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertRegisterOperationsEqual = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertRegisterOperationsEqual));
            this.Oracle_AlternatingBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_AlternatingBits));
            this.Oracle_AlternatingBits_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit)>>(typeof(Oracle_AlternatingBits_Reference));
            this.QubitArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(QubitArrayWrapperOperation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_Oracle_AlternatingBits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_Oracle_ArbitraryPattern_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_Oracle_ArbitraryPattern_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_Oracle_ArbitraryPattern_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T13_Oracle_ArbitraryPattern_Test";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomIntPow2
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> QubitArrayWrapperOperation
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 54 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            foreach (var n in new Range(2L, 10L))
#line hidden
            {
#line 55 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var pattern = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((MicrosoftQuantumMathRandomIntPow2.Apply(n), n));
#line 56 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var testOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg1__) => (Oracle_ArbitraryPattern.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg2__) => (__arg2__.Item1, __arg2__.Item2, pattern))), __arg1__)));
#line 57 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var refOp = QubitArrayWrapperOperation.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg3__) => (Oracle_ArbitraryPattern_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg4__) => (__arg4__.Item1, __arg4__.Item2, pattern))), __arg3__)));
#line 58 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply(((n + 1L), testOp, refOp));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathRandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomIntPow2));
            this.Oracle_ArbitraryPattern = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
            this.QubitArrayWrapperOperation = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(QubitArrayWrapperOperation));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_Oracle_ArbitraryPattern_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T14_OracleConverter_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_OracleConverter_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_OracleConverter_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T14_OracleConverter_Test";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomIntPow2
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 65 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            foreach (var n in new Range(2L, 10L))
#line hidden
            {
#line 66 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var pattern = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((MicrosoftQuantumMathRandomIntPow2.Apply(n), n));
#line 67 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var markingOracle = Oracle_ArbitraryPattern_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, pattern)));
#line 68 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var phaseOracleRef = OracleConverter_Reference.Apply(markingOracle);
#line 69 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var phaseOracleSol = OracleConverter.Apply(markingOracle);
#line 70 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((n, phaseOracleSol, phaseOracleRef));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathRandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomIntPow2));
            this.OracleConverter = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter));
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_OracleConverter_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T21_HadamardTransform_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_HadamardTransform_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_HadamardTransform_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T21_HadamardTransform_Test";
        protected ICallable<(ICallable,IAdjointable), QVoid> AssertRegisterOperationsEqual
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> HadamardTransform_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 77 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            AssertRegisterOperationsEqual.Apply((HadamardTransform, HadamardTransform_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertRegisterOperationsEqual = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertRegisterOperationsEqual));
            this.HadamardTransform = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform));
            this.HadamardTransform_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(HadamardTransform_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_HadamardTransform_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T22_ConditionalPhaseFlip_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_ConditionalPhaseFlip_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_ConditionalPhaseFlip_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T22_ConditionalPhaseFlip_Test";
        protected ICallable<(ICallable,IAdjointable), QVoid> AssertRegisterOperationsEqual
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ConditionalPhaseFlip
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> ConditionalPhaseFlip_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 83 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            AssertRegisterOperationsEqual.Apply((ConditionalPhaseFlip, ConditionalPhaseFlip_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertRegisterOperationsEqual = this.Factory.Get<ICallable<(ICallable,IAdjointable), QVoid>>(typeof(AssertRegisterOperationsEqual));
            this.ConditionalPhaseFlip = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ConditionalPhaseFlip));
            this.ConditionalPhaseFlip_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(ConditionalPhaseFlip_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_ConditionalPhaseFlip_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T23_GroverIteration_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_GroverIteration_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_GroverIteration_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T23_GroverIteration_Test";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomIntPow2
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> GroverIteration
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable)> GroverIteration_Reference
        {
            get;
            set;
        }

        protected ICallable<IAdjointable, IAdjointable> OracleConverter_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 89 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            foreach (var n in new Range(2L, 10L))
#line hidden
            {
#line 90 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var pattern = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((MicrosoftQuantumMathRandomIntPow2.Apply(n), n));
#line 91 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var markingOracle = Oracle_ArbitraryPattern_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, pattern)));
#line 92 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var flipOracle = OracleConverter_Reference.Apply(markingOracle);
#line 93 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var testOp = GroverIteration.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg2__) => (__arg2__, flipOracle)));
#line 94 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var refOp = GroverIteration_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable)>((__arg3__) => (__arg3__, flipOracle)));
#line 95 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((n, testOp, refOp));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathRandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomIntPow2));
            this.GroverIteration = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(GroverIteration));
            this.GroverIteration_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable)>>(typeof(GroverIteration_Reference));
            this.OracleConverter_Reference = this.Factory.Get<ICallable<IAdjointable, IAdjointable>>(typeof(OracleConverter_Reference));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_GroverIteration_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T31_GroversSearch_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T31_GroversSearch_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T31_GroversSearch_Test";
        String ICallable.FullName => "Quantum.Kata.GroversAlgorithm.T31_GroversSearch_Test";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomIntPow2
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IAdjointable,Int64), QVoid> GroversSearch
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)> GroversSearch_Reference
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)> Oracle_ArbitraryPattern_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 102 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
            foreach (var n in new Range(2L, 10L))
#line hidden
            {
#line 103 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var pattern = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((MicrosoftQuantumMathRandomIntPow2.Apply(n), n));
#line 104 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var markingOracle = Oracle_ArbitraryPattern_Reference.Partial(new Func<(IQArray<Qubit>,Qubit), (IQArray<Qubit>,Qubit,IQArray<Boolean>)>((__arg1__) => (__arg1__.Item1, __arg1__.Item2, pattern)));
#line 105 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var testOp = GroversSearch.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable,Int64)>((__arg2__) => (__arg2__, markingOracle, 4L)));
#line 106 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                var refOp = GroversSearch_Reference.Partial(new Func<IQArray<Qubit>, (IQArray<Qubit>,IAdjointable,Int64)>((__arg3__) => (__arg3__, markingOracle, 4L)));
#line 107 "G:\\量子实习\\quantumKatas-VS\\GroversAlgorithm\\Tests.qs"
                MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((n, testOp, refOp));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumMathRandomIntPow2 = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomIntPow2));
            this.GroversSearch = this.Factory.Get<ICallable<(IQArray<Qubit>,IAdjointable,Int64), QVoid>>(typeof(GroversSearch));
            this.GroversSearch_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IAdjointable,Int64)>>(typeof(GroversSearch_Reference));
            this.Oracle_ArbitraryPattern_Reference = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Qubit,IQArray<Boolean>)>>(typeof(Oracle_ArbitraryPattern_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T31_GroversSearch_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}