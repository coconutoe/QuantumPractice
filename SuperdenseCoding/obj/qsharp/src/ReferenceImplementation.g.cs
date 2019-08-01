#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":40}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":79}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.SuperdenseCoding.CreateEntangledPair_Reference\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"EncodeMessageInQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":84}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"EncodeMessageInQubit_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"DecodeMessageFromQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":66}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":93}}]}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"DecodeMessageFromQubits_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":44}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"SuperdenseCodingProtocol_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":72}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":91}}]}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"SuperdenseCodingProtocol_Reference\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/ReferenceImplementation.qs\",\"Position\":{\"Item1\":82,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":45}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.SuperdenseCoding
{
    public partial class CreateEntangledPair_Reference : Adjointable<(Qubit,Qubit)>, ICallable
    {
        public CreateEntangledPair_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
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

        String ICallable.Name => "CreateEntangledPair_Reference";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.CreateEntangledPair_Reference";
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

        public override Func<(Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (q1,q2) = __in__;
#line 22 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicH.Apply(q1);
#line 29 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((q1, q2));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (q1,q2) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((q1, q2));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(q1);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit q1, Qubit q2)
        {
            return __m__.Run<CreateEntangledPair_Reference, (Qubit,Qubit), QVoid>((q1, q2));
        }
    }

    public partial class EncodeMessageInQubit_Reference : Operation<(Qubit,ProtocolMessage), QVoid>, ICallable
    {
        public EncodeMessageInQubit_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,ProtocolMessage)>, IApplyData
        {
            public In((Qubit,ProtocolMessage) data) : base(data)
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

        String ICallable.Name => "EncodeMessageInQubit_Reference";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.EncodeMessageInQubit_Reference";
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

        public override Func<(Qubit,ProtocolMessage), QVoid> Body => (__in__) =>
        {
            var (qAlice,message) = __in__;
#line 49 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            if (message.Bit1)
            {
#line 50 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicZ.Apply(qAlice);
            }

#line 53 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            if (message.Bit2)
            {
#line 54 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                MicrosoftQuantumIntrinsicX.Apply(qAlice);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn((Qubit,ProtocolMessage) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qAlice, ProtocolMessage message)
        {
            return __m__.Run<EncodeMessageInQubit_Reference, (Qubit,ProtocolMessage), QVoid>((qAlice, message));
        }
    }

    public partial class DecodeMessageFromQubits_Reference : Operation<(Qubit,Qubit), ProtocolMessage>, ICallable
    {
        public DecodeMessageFromQubits_Reference(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
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

        String ICallable.Name => "DecodeMessageFromQubits_Reference";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.DecodeMessageFromQubits_Reference";
        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit)> CreateEntangledPair_Reference
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean), ProtocolMessage> ProtocolMessage
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), ProtocolMessage> Body => (__in__) =>
        {
            var (qAlice,qBob) = __in__;
#line 67 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            CreateEntangledPair_Reference.Adjoint.Apply((qAlice, qBob));
#line 78 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
            return new ProtocolMessage(((MicrosoftQuantumMeasurementMResetZ.Apply(qAlice) == Result.One), (MicrosoftQuantumMeasurementMResetZ.Apply(qBob) == Result.One)));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(CreateEntangledPair_Reference));
            this.ProtocolMessage = this.Factory.Get<ICallable<(Boolean,Boolean), ProtocolMessage>>(typeof(ProtocolMessage));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(ProtocolMessage data) => data;
        public static System.Threading.Tasks.Task<ProtocolMessage> Run(IOperationFactory __m__, Qubit qAlice, Qubit qBob)
        {
            return __m__.Run<DecodeMessageFromQubits_Reference, (Qubit,Qubit), ProtocolMessage>((qAlice, qBob));
        }
    }

    public partial class SuperdenseCodingProtocol_Reference : Operation<ProtocolMessage, ProtocolMessage>, ICallable
    {
        public SuperdenseCodingProtocol_Reference(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SuperdenseCodingProtocol_Reference";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.SuperdenseCodingProtocol_Reference";
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

        protected IAdjointable<(Qubit,Qubit)> CreateEntangledPair_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), ProtocolMessage> DecodeMessageFromQubits_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,ProtocolMessage), QVoid> EncodeMessageInQubit_Reference
        {
            get;
            set;
        }

        public override Func<ProtocolMessage, ProtocolMessage> Body => (__in__) =>
        {
            var message = __in__;
#line hidden
            {
#line 86 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                var (q1,q2) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 89 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                    CreateEntangledPair_Reference.Apply((q1, q2));
#line 95 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                    EncodeMessageInQubit_Reference.Apply((q1, message));
#line 102 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\ReferenceImplementation.qs"
                    return DecodeMessageFromQubits_Reference.Apply((q1, q2));
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
                    Release.Apply(q1);
#line hidden
                    Release.Apply(q2);
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(CreateEntangledPair_Reference));
            this.DecodeMessageFromQubits_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), ProtocolMessage>>(typeof(DecodeMessageFromQubits_Reference));
            this.EncodeMessageInQubit_Reference = this.Factory.Get<ICallable<(Qubit,ProtocolMessage), QVoid>>(typeof(EncodeMessageInQubit_Reference));
        }

        public override IApplyData __dataIn(ProtocolMessage data) => data;
        public override IApplyData __dataOut(ProtocolMessage data) => data;
        public static System.Threading.Tasks.Task<ProtocolMessage> Run(IOperationFactory __m__, ProtocolMessage message)
        {
            return __m__.Run<SuperdenseCodingProtocol_Reference, ProtocolMessage, ProtocolMessage>(message);
        }
    }
}