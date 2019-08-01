#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"TypeConstructor\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Bit1\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Bit2\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":1}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}}},\"Documentation\":[\"type constructor for user defined type\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":true}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: TypeDeclaration("{\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":13,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":9},\"Item2\":{\"Line\":1,\"Column\":24}},\"Type\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"TypeItems\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Named\",\"Fields\":[{\"VariableName\":\"Bit1\",\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"Case\":\"Named\",\"Fields\":[{\"VariableName\":\"Bit2\",\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]}]]},\"Documentation\":[\" # Summary\",\" Data type that represents the message that is transmitted\",\" as part of the superdense coding protocol.\",\" It includes two classical bits (Bit1 and Bit2) of type Bool.\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"CreateEntangledPair\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":69}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.SuperdenseCoding.CreateEntangledPair\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"EncodeMessageInQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":62,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":74}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"EncodeMessageInQubit\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":62,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"DecodeMessageFromQubits\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qAlice\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qBob\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":56}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":83}}]}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"DecodeMessageFromQubits\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":91,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"SuperdenseCodingProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":62}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":81}}]}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"SuperdenseCodingProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tasks.qs\",\"Position\":{\"Item1\":122,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.SuperdenseCoding
{
    public class ProtocolMessage : UDTBase<(Boolean,Boolean)>, IApplyData
    {
        public ProtocolMessage() : base(default((Boolean,Boolean)))
        {
        }

        public ProtocolMessage((Boolean,Boolean) data) : base(data)
        {
        }

        public Boolean Bit1 => Data.Item1;
        public Boolean Bit2 => Data.Item2;
        public Boolean Item1 => Data.Item1;
        public Boolean Item2 => Data.Item2;
        System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        public void Deconstruct(out Boolean item1, out Boolean item2)
        {
            item1 = Data.Item1;
            item2 = Data.Item2;
        }
    }

    public partial class CreateEntangledPair : Adjointable<(Qubit,Qubit)>, ICallable
    {
        public CreateEntangledPair(IOperationFactory m) : base(m)
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

        String ICallable.Name => "CreateEntangledPair";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.CreateEntangledPair";
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
#line 51 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(q1);
#line 52 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
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
            return __m__.Run<CreateEntangledPair, (Qubit,Qubit), QVoid>((q1, q2));
        }
    }

    public partial class EncodeMessageInQubit : Operation<(Qubit,ProtocolMessage), QVoid>, ICallable
    {
        public EncodeMessageInQubit(IOperationFactory m) : base(m)
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

        String ICallable.Name => "EncodeMessageInQubit";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.EncodeMessageInQubit";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicY
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
#line 72 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            if ((!(message.Bit1) && message.Bit2))
            {
#line 73 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qAlice);
            }
            else if ((message.Bit1 && !(message.Bit2)))
            {
#line 75 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicZ.Apply(qAlice);
            }
            else if ((message.Bit1 && message.Bit2))
            {
#line 77 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicY.Apply(qAlice);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.MicrosoftQuantumIntrinsicY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Y));
            this.MicrosoftQuantumIntrinsicZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.Z));
        }

        public override IApplyData __dataIn((Qubit,ProtocolMessage) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qAlice, ProtocolMessage message)
        {
            return __m__.Run<EncodeMessageInQubit, (Qubit,ProtocolMessage), QVoid>((qAlice, message));
        }
    }

    public partial class DecodeMessageFromQubits : Operation<(Qubit,Qubit), ProtocolMessage>, ICallable
    {
        public DecodeMessageFromQubits(IOperationFactory m) : base(m)
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

        String ICallable.Name => "DecodeMessageFromQubits";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.DecodeMessageFromQubits";
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

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
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
#line 94 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qAlice, qBob));
#line 95 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            MicrosoftQuantumIntrinsicH.Apply(qAlice);
#line 96 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            var res1 = MicrosoftQuantumIntrinsicM.Apply(qAlice);
#line 97 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            var res2 = MicrosoftQuantumIntrinsicM.Apply(qBob);
#line 98 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            if (((res1 == Result.Zero) && (res2 == Result.Zero)))
            {
#line 100 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                return new ProtocolMessage((false, false));
            }
            else if (((res1 == Result.Zero) && (res2 == Result.One)))
            {
#line 102 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qBob);
#line 103 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                return new ProtocolMessage((false, true));
            }
            else if (((res1 == Result.One) && (res2 == Result.Zero)))
            {
#line 105 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qAlice);
#line 106 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                return new ProtocolMessage((true, false));
            }
            else
            {
#line 108 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qAlice);
#line 109 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                MicrosoftQuantumIntrinsicX.Apply(qBob);
#line 110 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
                return new ProtocolMessage((true, true));
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.ProtocolMessage = this.Factory.Get<ICallable<(Boolean,Boolean), ProtocolMessage>>(typeof(ProtocolMessage));
        }

        public override IApplyData __dataIn((Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(ProtocolMessage data) => data;
        public static System.Threading.Tasks.Task<ProtocolMessage> Run(IOperationFactory __m__, Qubit qAlice, Qubit qBob)
        {
            return __m__.Run<DecodeMessageFromQubits, (Qubit,Qubit), ProtocolMessage>((qAlice, qBob));
        }
    }

    public partial class SuperdenseCodingProtocol : Operation<ProtocolMessage, ProtocolMessage>, ICallable
    {
        public SuperdenseCodingProtocol(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SuperdenseCodingProtocol";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.SuperdenseCodingProtocol";
        public override Func<ProtocolMessage, ProtocolMessage> Body => (__in__) =>
        {
            var message = __in__;
#line 125 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tasks.qs"
            return message;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(ProtocolMessage data) => data;
        public override IApplyData __dataOut(ProtocolMessage data) => data;
        public static System.Threading.Tasks.Task<ProtocolMessage> Run(IOperationFactory __m__, ProtocolMessage message)
        {
            return __m__.Run<SuperdenseCodingProtocol, ProtocolMessage, ProtocolMessage>(message);
        }
    }
}