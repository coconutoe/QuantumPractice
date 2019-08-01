#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Function\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RefereeBits\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"RefereeBits\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":10},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T11_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T11_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"GetClassicalStrategySuccessRate\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"strategy\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Bool\"},\"Item2\":{\"Case\":\"Bool\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"Double\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"GetClassicalStrategySuccessRate\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":39,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":42}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T12_RandomClassical_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T12_RandomClassical_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":52,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T13_BestClassical_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T13_BestClassical_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"TestStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"mode\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"TestStrategy\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":64,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T14_PlayClassicalGHZ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T14_PlayClassicalGHZ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"taskImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":81}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":85,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T21_CreateEntangledTriple_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T21_CreateEntangledTriple_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":98,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":41}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T22_QuantumStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T22_QuantumStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":104,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T23_PlayQuantumGHZ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":126,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.GHZGame\",\"Name\":\"T23_PlayQuantumGHZ_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/GHZGame/Tests.qs\",\"Position\":{\"Item1\":126,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.GHZGame
{
    public partial class RefereeBits : Function<QVoid, IQArray<IQArray<Boolean>>>, ICallable
    {
        public RefereeBits(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RefereeBits";
        String ICallable.FullName => "Quantum.Kata.GHZGame.RefereeBits";
        public override Func<QVoid, IQArray<IQArray<Boolean>>> Body => (__in__) =>
        {
#line 20 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            return new QArray<IQArray<Boolean>>(new QArray<Boolean>(false, false, false), new QArray<Boolean>(true, true, false), new QArray<Boolean>(false, true, true), new QArray<Boolean>(true, false, true));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(IQArray<IQArray<Boolean>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Boolean>>> Run(IOperationFactory __m__)
        {
            return __m__.Run<RefereeBits, QVoid, IQArray<IQArray<Boolean>>>(QVoid.Instance);
        }
    }

    public partial class T11_WinCondition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_WinCondition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_WinCondition_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T11_WinCondition_Test";
        protected ICallable<(Int64,Int64), IQArray<Boolean>> MicrosoftQuantumConvertIntAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected ICallable<QVoid, IQArray<IQArray<Boolean>>> RefereeBits
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean> WinCondition
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean> WinCondition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 27 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            foreach (var rst in RefereeBits.Apply(QVoid.Instance))
#line hidden
            {
#line 28 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                foreach (var i in new Range(0L, (1L << (int)(3L - 1L))))
#line hidden
                {
#line 29 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    var abc = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((i, 3L));
#line 30 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((WinCondition.Apply((rst, abc)), WinCondition_Reference.Apply((rst, abc)), String.Format("Win condition is wrong for rst={0}, abc={1}", rst, abc)));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.RefereeBits = this.Factory.Get<ICallable<QVoid, IQArray<IQArray<Boolean>>>>(typeof(RefereeBits));
            this.WinCondition = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean>>(typeof(WinCondition));
            this.WinCondition_Reference = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean>>(typeof(WinCondition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_WinCondition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class GetClassicalStrategySuccessRate : Operation<(Int64,ICallable), Double>, ICallable
    {
        public GetClassicalStrategySuccessRate(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "GetClassicalStrategySuccessRate";
        String ICallable.FullName => "Quantum.Kata.GHZGame.GetClassicalStrategySuccessRate";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>> PlayClassicalGHZ_Reference
        {
            get;
            set;
        }

        protected ICallable<QVoid, IQArray<IQArray<Boolean>>> RefereeBits
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean> WinCondition_Reference
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Double> Body => (__in__) =>
        {
            var (N,strategy) = __in__;
#line 41 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            var inputs = (IQArray<IQArray<Boolean>>)RefereeBits.Apply(QVoid.Instance);
#line 42 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            var wins = 0L;
#line 43 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            foreach (var i in new Range(0L, (N - 1L)))
#line hidden
            {
#line 44 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var rst = (IQArray<Boolean>)inputs[MicrosoftQuantumMathRandomInt.Apply(inputs.Length)];
#line 45 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var abc = (IQArray<Boolean>)PlayClassicalGHZ_Reference.Apply((strategy, rst));
#line 46 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                if (WinCondition_Reference.Apply((rst, abc)))
                {
#line 47 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    wins = (wins + 1L);
                }
            }

#line 50 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            return (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / MicrosoftQuantumConvertIntAsDouble.Apply(N));
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.PlayClassicalGHZ_Reference = this.Factory.Get<ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>>>(typeof(PlayClassicalGHZ_Reference));
            this.RefereeBits = this.Factory.Get<ICallable<QVoid, IQArray<IQArray<Boolean>>>>(typeof(RefereeBits));
            this.WinCondition_Reference = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean>>(typeof(WinCondition_Reference));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 N, ICallable strategy)
        {
            return __m__.Run<GetClassicalStrategySuccessRate, (Int64,ICallable), Double>((N, strategy));
        }
    }

    public partial class T12_RandomClassical_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_RandomClassical_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_RandomClassical_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T12_RandomClassical_Test";
        protected ICallable<(Double,Double,Double), QVoid> MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Double> GetClassicalStrategySuccessRate
        {
            get;
            set;
        }

        protected ICallable<Boolean, Boolean> RandomClassicalStrategy
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 54 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((GetClassicalStrategySuccessRate.Apply((10000L, RandomClassicalStrategy)), 0.5D, 0.02D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityWithinToleranceFact));
            this.GetClassicalStrategySuccessRate = this.Factory.Get<ICallable<(Int64,ICallable), Double>>(typeof(GetClassicalStrategySuccessRate));
            this.RandomClassicalStrategy = this.Factory.Get<ICallable<Boolean, Boolean>>(typeof(RandomClassicalStrategy));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_RandomClassical_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T13_BestClassical_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T13_BestClassical_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T13_BestClassical_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T13_BestClassical_Test";
        protected ICallable<(Double,Double,Double), QVoid> MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact
        {
            get;
            set;
        }

        protected ICallable<Boolean, Boolean> BestClassicalStrategy
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Double> GetClassicalStrategySuccessRate
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 60 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply((GetClassicalStrategySuccessRate.Apply((10000L, BestClassicalStrategy)), 0.75D, 0.02D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityWithinToleranceFact));
            this.BestClassicalStrategy = this.Factory.Get<ICallable<Boolean, Boolean>>(typeof(BestClassicalStrategy));
            this.GetClassicalStrategySuccessRate = this.Factory.Get<ICallable<(Int64,ICallable), Double>>(typeof(GetClassicalStrategySuccessRate));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T13_BestClassical_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class TestStrategy : Operation<(Boolean,Int64), Boolean>, ICallable
    {
        public TestStrategy(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Int64)>, IApplyData
        {
            public In((Boolean,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "TestStrategy";
        String ICallable.FullName => "Quantum.Kata.GHZGame.TestStrategy";
        public override Func<(Boolean,Int64), Boolean> Body => (__in__) =>
        {
            var (input,mode) = __in__;
#line 66 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            return ((((mode == 0L) ? false : (mode == 1L)) ? true : (mode == 2L)) ? input : !(input));
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Boolean,Int64) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean input, Int64 mode)
        {
            return __m__.Run<TestStrategy, (Boolean,Int64), Boolean>((input, mode));
        }
    }

    public partial class T14_PlayClassicalGHZ_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T14_PlayClassicalGHZ_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T14_PlayClassicalGHZ_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T14_PlayClassicalGHZ_Test";
        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>,String), QVoid> MicrosoftQuantumDiagnosticsAllEqualityFactB
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>> PlayClassicalGHZ
        {
            get;
            set;
        }

        protected ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>> PlayClassicalGHZ_Reference
        {
            get;
            set;
        }

        protected ICallable<QVoid, IQArray<IQArray<Boolean>>> RefereeBits
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Int64), Boolean> TestStrategy
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 72 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            var inputs = (IQArray<IQArray<Boolean>>)RefereeBits.Apply(QVoid.Instance);
#line 73 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            foreach (var rst in inputs)
#line hidden
            {
#line 74 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                foreach (var mode in new Range(0L, 3L))
#line hidden
                {
#line 75 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    var result = (IQArray<Boolean>)PlayClassicalGHZ.Apply((TestStrategy.Partial(new Func<Boolean, (Boolean,Int64)>((__arg1__) => (__arg1__, mode))), rst));
#line 76 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    var expected = (IQArray<Boolean>)PlayClassicalGHZ_Reference.Apply((TestStrategy.Partial(new Func<Boolean, (Boolean,Int64)>((__arg2__) => (__arg2__, mode))), rst));
#line 77 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAllEqualityFactB.Apply((result, expected, String.Format("Unexpected result for rst={0}", rst)));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAllEqualityFactB = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AllEqualityFactB));
            this.PlayClassicalGHZ = this.Factory.Get<ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>>>(typeof(PlayClassicalGHZ));
            this.PlayClassicalGHZ_Reference = this.Factory.Get<ICallable<(ICallable,IQArray<Boolean>), IQArray<Boolean>>>(typeof(PlayClassicalGHZ_Reference));
            this.RefereeBits = this.Factory.Get<ICallable<QVoid, IQArray<IQArray<Boolean>>>>(typeof(RefereeBits));
            this.TestStrategy = this.Factory.Get<ICallable<(Boolean,Int64), Boolean>>(typeof(TestStrategy));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T14_PlayClassicalGHZ_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class AssertEqualOnZeroState : Operation<(Int64,ICallable,IAdjointable), QVoid>, ICallable
    {
        public AssertEqualOnZeroState(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable,IAdjointable)>, IApplyData
        {
            public In((Int64,ICallable,IAdjointable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "AssertEqualOnZeroState";
        String ICallable.FullName => "Quantum.Kata.GHZGame.AssertEqualOnZeroState";
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

        public override Func<(Int64,ICallable,IAdjointable), QVoid> Body => (__in__) =>
        {
            var (N,taskImpl,refImpl) = __in__;
#line hidden
            {
#line 87 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var qs = Allocate.Apply(N);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 89 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    taskImpl.Apply(qs);
#line 92 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    refImpl.Adjoint.Apply(qs);
#line 95 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsAssertAllZero.Apply(qs);
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

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertAllZero = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(Microsoft.Quantum.Diagnostics.AssertAllZero));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
        }

        public override IApplyData __dataIn((Int64,ICallable,IAdjointable) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N, ICallable taskImpl, IAdjointable refImpl)
        {
            return __m__.Run<AssertEqualOnZeroState, (Int64,ICallable,IAdjointable), QVoid>((N, taskImpl, refImpl));
        }
    }

    public partial class T21_CreateEntangledTriple_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_CreateEntangledTriple_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_CreateEntangledTriple_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T21_CreateEntangledTriple_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> CreateEntangledTriple
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> CreateEntangledTriple_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 100 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            AssertEqualOnZeroState.Apply((3L, CreateEntangledTriple, CreateEntangledTriple_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.CreateEntangledTriple = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(CreateEntangledTriple));
            this.CreateEntangledTriple_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CreateEntangledTriple_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_CreateEntangledTriple_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T22_QuantumStrategy_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_QuantumStrategy_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_QuantumStrategy_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T22_QuantumStrategy_Test";
        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
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

        protected ICallable<Qubit, QVoid> MicrosoftQuantumIntrinsicReset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Boolean> QuantumStrategy
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 106 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 107 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((QuantumStrategy.Apply((false, q)), false, "|0⟩ not measured as false"));
#line 108 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 110 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 111 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((QuantumStrategy.Apply((false, q)), true, "|1⟩ not measured as true"));
#line 112 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 114 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 115 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((QuantumStrategy.Apply((true, q)), false, "|+⟩ is not measured as false"));
#line 116 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 118 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 119 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 120 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((QuantumStrategy.Apply((true, q)), true, "|-⟩ is not measured as true"));
#line 121 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
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
                    Release.Apply(q);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QuantumStrategy = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(QuantumStrategy));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_QuantumStrategy_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T23_PlayQuantumGHZ_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_PlayQuantumGHZ_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_PlayQuantumGHZ_Test";
        String ICallable.FullName => "Quantum.Kata.GHZGame.T23_PlayQuantumGHZ_Test";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Boolean,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactB
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<IQArray<ICallable>, IQArray<Boolean>> PlayQuantumGHZ
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Boolean> QuantumStrategy
        {
            get;
            set;
        }

        protected ICallable<QVoid, IQArray<IQArray<Boolean>>> RefereeBits
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean> WinCondition_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 128 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
            foreach (var i in new Range(0L, 1000L))
#line hidden
            {
#line 129 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var rst = (IQArray<Boolean>)RefereeBits.Apply(QVoid.Instance)[MicrosoftQuantumMathRandomInt.Apply(RefereeBits.Apply(QVoid.Instance).Length)];
#line 130 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var strategies = (IQArray<ICallable>)new QArray<ICallable>(QuantumStrategy.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg1__) => (rst[0L], __arg1__))), QuantumStrategy.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg2__) => (rst[1L], __arg2__))), QuantumStrategy.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg3__) => (rst[2L], __arg3__))));
#line 131 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                var abc = (IQArray<Boolean>)PlayQuantumGHZ.Apply(strategies);
#line 132 "G:\\量子实习\\quantumKatas-VS\\GHZGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsEqualityFactB.Apply((WinCondition_Reference.Apply((rst, abc)), true, String.Format("Quantum strategy lost: for rst={0} the players returned abc={1}", rst, abc)));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.PlayQuantumGHZ = this.Factory.Get<ICallable<IQArray<ICallable>, IQArray<Boolean>>>(typeof(PlayQuantumGHZ));
            this.QuantumStrategy = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(QuantumStrategy));
            this.RefereeBits = this.Factory.Get<ICallable<QVoid, IQArray<IQArray<Boolean>>>>(typeof(RefereeBits));
            this.WinCondition_Reference = this.Factory.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Boolean>>(typeof(WinCondition_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_PlayQuantumGHZ_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}