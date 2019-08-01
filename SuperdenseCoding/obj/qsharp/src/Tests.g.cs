#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T1_CreateEntangledPair_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T1_CreateEntangledPair_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":38}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ComposeProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"encodeOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":2,\"Column\":14},\"Item2\":{\"Line\":2,\"Column\":48}}]}}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":3},\"Item2\":{\"Line\":2,\"Column\":11}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"decodeOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":3,\"Column\":14},\"Item2\":{\"Line\":3,\"Column\":49}}]}}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":3},\"Item2\":{\"Line\":3,\"Column\":11}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"message\"]},\"Type\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":4,\"Column\":13},\"Item2\":{\"Line\":4,\"Column\":28}}]}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":3},\"Item2\":{\"Line\":4,\"Column\":10}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}]]},\"ReturnType\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":5,\"Column\":6},\"Item2\":{\"Line\":5,\"Column\":21}}]}}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ComposeProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":35,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"TestProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"protocolOp\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":74}}]}}]},\"Item2\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":74}}]}}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]},\"Item2\":{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"ProtocolMessage\",\"Range\":{\"Case\":\"Null\"}}]}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"TestProtocol\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T2_EncodeMessageInQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T2_EncodeMessageInQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T3_DecodeMessageFromQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T3_DecodeMessageFromQubits_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T4_SuperdenseCodingProtocol_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.SuperdenseCoding\",\"Name\":\"T4_SuperdenseCodingProtocol_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/SuperdenseCoding/Tests.qs\",\"Position\":{\"Item1\":79,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":43}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.SuperdenseCoding
{
    public partial class T1_CreateEntangledPair_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T1_CreateEntangledPair_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T1_CreateEntangledPair_Test";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.T1_CreateEntangledPair_Test";
        protected IUnitary<IQArray<Qubit>> MicrosoftQuantumDiagnosticsAssertAllZero
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

        protected IAdjointable<(Qubit,Qubit)> CreateEntangledPair
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit)> CreateEntangledPair_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 19 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                var (q1,q2) = (Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 22 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    CreateEntangledPair.Apply((q1, q2));
#line 25 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    CreateEntangledPair_Reference.Adjoint.Apply((q1, q2));
#line 28 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertAllZero.Apply(new QArray<Qubit>(q1, q2));
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.CreateEntangledPair = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(CreateEntangledPair));
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(CreateEntangledPair_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T1_CreateEntangledPair_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class ComposeProtocol : Operation<(ICallable,ICallable,ProtocolMessage), ProtocolMessage>, ICallable
    {
        public ComposeProtocol(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,ICallable,ProtocolMessage)>, IApplyData
        {
            public In((ICallable,ICallable,ProtocolMessage) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ComposeProtocol";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.ComposeProtocol";
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

        public override Func<(ICallable,ICallable,ProtocolMessage), ProtocolMessage> Body => (__in__) =>
        {
            var (encodeOp,decodeOp,message) = __in__;
#line hidden
            {
#line 42 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                var qs = Allocate.Apply(2L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 43 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    CreateEntangledPair_Reference.Apply((qs[0L], qs[1L]));
#line 44 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    encodeOp.Apply((qs[0L], message));
#line 45 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    return decodeOp.Apply<ProtocolMessage>((qs[0L], qs[1L]));
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
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<(Qubit,Qubit)>>(typeof(CreateEntangledPair_Reference));
        }

        public override IApplyData __dataIn((ICallable,ICallable,ProtocolMessage) data) => new In(data);
        public override IApplyData __dataOut(ProtocolMessage data) => data;
        public static System.Threading.Tasks.Task<ProtocolMessage> Run(IOperationFactory __m__, ICallable encodeOp, ICallable decodeOp, ProtocolMessage message)
        {
            return __m__.Run<ComposeProtocol, (ICallable,ICallable,ProtocolMessage), ProtocolMessage>((encodeOp, decodeOp, message));
        }
    }

    public partial class TestProtocol : Operation<ICallable, QVoid>, ICallable
    {
        public TestProtocol(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestProtocol";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.TestProtocol";
        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean), ProtocolMessage> ProtocolMessage
        {
            get;
            set;
        }

        public override Func<ICallable, QVoid> Body => (__in__) =>
        {
            var protocolOp = __in__;
#line 56 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
            foreach (var n in new Range(0L, 3L))
#line hidden
            {
#line 57 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                var data = new ProtocolMessage(((1L == (n / 2L)), (1L == (n % 2L))));
#line 59 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                foreach (var iter in new Range(1L, 100L))
#line hidden
                {
#line 60 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    var result = protocolOp.Apply<ProtocolMessage>(data);
#line 63 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
                    MicrosoftQuantumDiagnosticsFact.Apply((((result.Bit1 == data.Bit1) && (result.Bit2 == data.Bit2)), String.Format("{0} was transfered incorrectly as {1}", data, result)));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.ProtocolMessage = this.Factory.Get<ICallable<(Boolean,Boolean), ProtocolMessage>>(typeof(ProtocolMessage));
        }

        public override IApplyData __dataIn(ICallable data) => new QTuple<ICallable>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable protocolOp)
        {
            return __m__.Run<TestProtocol, ICallable, QVoid>(protocolOp);
        }
    }

    public partial class T2_EncodeMessageInQubit_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T2_EncodeMessageInQubit_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T2_EncodeMessageInQubit_Test";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.T2_EncodeMessageInQubit_Test";
        protected ICallable<(ICallable,ICallable,ProtocolMessage), ProtocolMessage> ComposeProtocol
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), ProtocolMessage> DecodeMessageFromQubits_Reference
        {
            get;
            set;
        }

        protected ICallable<(Qubit,ProtocolMessage), QVoid> EncodeMessageInQubit
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestProtocol
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 71 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
            TestProtocol.Apply(ComposeProtocol.Partial(new Func<ProtocolMessage, (ICallable,ICallable,ProtocolMessage)>((__arg1__) => (EncodeMessageInQubit, DecodeMessageFromQubits_Reference, __arg1__))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeProtocol = this.Factory.Get<ICallable<(ICallable,ICallable,ProtocolMessage), ProtocolMessage>>(typeof(ComposeProtocol));
            this.DecodeMessageFromQubits_Reference = this.Factory.Get<ICallable<(Qubit,Qubit), ProtocolMessage>>(typeof(DecodeMessageFromQubits_Reference));
            this.EncodeMessageInQubit = this.Factory.Get<ICallable<(Qubit,ProtocolMessage), QVoid>>(typeof(EncodeMessageInQubit));
            this.TestProtocol = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TestProtocol));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T2_EncodeMessageInQubit_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T3_DecodeMessageFromQubits_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T3_DecodeMessageFromQubits_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T3_DecodeMessageFromQubits_Test";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.T3_DecodeMessageFromQubits_Test";
        protected ICallable<(ICallable,ICallable,ProtocolMessage), ProtocolMessage> ComposeProtocol
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Qubit), ProtocolMessage> DecodeMessageFromQubits
        {
            get;
            set;
        }

        protected ICallable<(Qubit,ProtocolMessage), QVoid> EncodeMessageInQubit_Reference
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestProtocol
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 76 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
            TestProtocol.Apply(ComposeProtocol.Partial(new Func<ProtocolMessage, (ICallable,ICallable,ProtocolMessage)>((__arg1__) => (EncodeMessageInQubit_Reference, DecodeMessageFromQubits, __arg1__))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ComposeProtocol = this.Factory.Get<ICallable<(ICallable,ICallable,ProtocolMessage), ProtocolMessage>>(typeof(ComposeProtocol));
            this.DecodeMessageFromQubits = this.Factory.Get<ICallable<(Qubit,Qubit), ProtocolMessage>>(typeof(DecodeMessageFromQubits));
            this.EncodeMessageInQubit_Reference = this.Factory.Get<ICallable<(Qubit,ProtocolMessage), QVoid>>(typeof(EncodeMessageInQubit_Reference));
            this.TestProtocol = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TestProtocol));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T3_DecodeMessageFromQubits_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T4_SuperdenseCodingProtocol_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T4_SuperdenseCodingProtocol_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T4_SuperdenseCodingProtocol_Test";
        String ICallable.FullName => "Quantum.Kata.SuperdenseCoding.T4_SuperdenseCodingProtocol_Test";
        protected ICallable<ProtocolMessage, ProtocolMessage> SuperdenseCodingProtocol
        {
            get;
            set;
        }

        protected ICallable<ICallable, QVoid> TestProtocol
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 81 "G:\\量子实习\\quantumKatas-VS\\SuperdenseCoding\\Tests.qs"
            TestProtocol.Apply(SuperdenseCodingProtocol);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.SuperdenseCodingProtocol = this.Factory.Get<ICallable<ProtocolMessage, ProtocolMessage>>(typeof(SuperdenseCodingProtocol));
            this.TestProtocol = this.Factory.Get<ICallable<ICallable, QVoid>>(typeof(TestProtocol));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T4_SuperdenseCodingProtocol_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}