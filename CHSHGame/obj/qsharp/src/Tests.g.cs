#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T11_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T11_WinCondition_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":18,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T12_ClassicalStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T12_ClassicalStrategy_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":31,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"taskImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"refImpl\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":39},\"Item2\":{\"Line\":2,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"AssertEqualOnZeroState\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":48,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":33}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T21_CreateEntangledPair_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T21_CreateEntangledPair_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":63,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":39}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T22_AliceQuantum_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T22_AliceQuantum_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":70,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"QubitToRegisterOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":92,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"QubitToRegisterOperation\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":92,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"QubitToRegisterOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"op\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"Qubit\"},\"Item2\":{\"Case\":\"UnitType\"}},{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"QubitToRegisterOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"QubitToRegisterOperationA\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":96,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":94}},\"Documentation\":[\"automatically generated QsAdjoint specialization for Quantum.Kata.CHSHGame.QubitToRegisterOperationA\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T23_RotateBobQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T23_RotateBobQubit_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":34}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T24_BobQuantum_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T24_BobQuantum_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":109,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T25_PlayQuantumCHSH_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Quantum.Kata.CHSHGame\",\"Name\":\"T25_PlayQuantumCHSH_Test\"},\"SourceFile\":\"G:/%E9%87%8F%E5%AD%90%E5%AE%9E%E4%B9%A0/quantumKatas-VS/CHSHGame/Tests.qs\",\"Position\":{\"Item1\":133,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":35}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.Kata.CHSHGame
{
    public partial class T11_WinCondition_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T11_WinCondition_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T11_WinCondition_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T11_WinCondition_Test";
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

        protected ICallable<(Boolean,Boolean,Boolean,Boolean), Boolean> WinCondition
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 20 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            foreach (var i in new Range(0L, (1L << (int)(4L - 1L))))
#line hidden
            {
#line 21 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var bits = (IQArray<Boolean>)MicrosoftQuantumConvertIntAsBoolArray.Apply((i, 4L));
#line 22 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                MicrosoftQuantumDiagnosticsEqualityFactB.Apply((WinCondition.Apply((bits[0L], bits[1L], bits[2L], bits[3L])), ((bits[0L] && bits[1L]) == (bits[2L] != bits[3L])), (String.Format("Win condition is wrong for X = {0}, Y = {1}, A = {2}, ", bits[0L], bits[1L], bits[2L]) + String.Format("B = {0}", bits[3L]))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsBoolArray = this.Factory.Get<ICallable<(Int64,Int64), IQArray<Boolean>>>(typeof(Microsoft.Quantum.Convert.IntAsBoolArray));
            this.MicrosoftQuantumDiagnosticsEqualityFactB = this.Factory.Get<ICallable<(Boolean,Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactB));
            this.WinCondition = this.Factory.Get<ICallable<(Boolean,Boolean,Boolean,Boolean), Boolean>>(typeof(WinCondition));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T11_WinCondition_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T12_ClassicalStrategy_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T12_ClassicalStrategy_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T12_ClassicalStrategy_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T12_ClassicalStrategy_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<Boolean, Boolean> AliceClassical
        {
            get;
            set;
        }

        protected ICallable<Boolean, Boolean> BobClassical
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 33 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            var wins = 0L;
#line 34 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            foreach (var i in new Range(1L, 1000L))
#line hidden
            {
#line 35 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var x = ((MicrosoftQuantumMathRandomInt.Apply(2L) == 1L) ? true : false);
#line 36 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var y = ((MicrosoftQuantumMathRandomInt.Apply(2L) == 1L) ? true : false);
#line 37 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var (a,b) = (AliceClassical.Apply(x), BobClassical.Apply(y));
#line 38 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                if (((x && y) == (a != b)))
                {
#line 39 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    wins = (wins + 1L);
                }
            }

#line 42 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Win rate {0}", (MicrosoftQuantumConvertIntAsDouble.Apply(wins) / 1000D)));
#line 44 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsFact.Apply(((wins >= 700L), "Alice and Bob's classical strategy is not optimal"));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.AliceClassical = this.Factory.Get<ICallable<Boolean, Boolean>>(typeof(AliceClassical));
            this.BobClassical = this.Factory.Get<ICallable<Boolean, Boolean>>(typeof(BobClassical));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T12_ClassicalStrategy_Test, QVoid, QVoid>(QVoid.Instance);
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
        String ICallable.FullName => "Quantum.Kata.CHSHGame.AssertEqualOnZeroState";
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
#line 51 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var qs = Allocate.Apply(N);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 53 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    taskImpl.Apply(qs);
#line 56 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    refImpl.Adjoint.Apply(qs);
#line 59 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
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

    public partial class T21_CreateEntangledPair_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T21_CreateEntangledPair_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T21_CreateEntangledPair_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T21_CreateEntangledPair_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> AssertEqualOnZeroState
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, QVoid> CreateEntangledPair
        {
            get;
            set;
        }

        protected IAdjointable<IQArray<Qubit>> CreateEntangledPair_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 66 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            AssertEqualOnZeroState.Apply((2L, CreateEntangledPair, CreateEntangledPair_Reference));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AssertEqualOnZeroState = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(AssertEqualOnZeroState));
            this.CreateEntangledPair = this.Factory.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(CreateEntangledPair));
            this.CreateEntangledPair_Reference = this.Factory.Get<IAdjointable<IQArray<Qubit>>>(typeof(CreateEntangledPair_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T21_CreateEntangledPair_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T22_AliceQuantum_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T22_AliceQuantum_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T22_AliceQuantum_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T22_AliceQuantum_Test";
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

        protected ICallable<(Boolean,Qubit), Boolean> AliceQuantum
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 72 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 73 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((AliceQuantum.Apply((false, q)), false, "|0⟩ not measured as false"));
#line 74 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 76 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 77 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((AliceQuantum.Apply((false, q)), true, "|1⟩ not measured as true"));
#line 78 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 80 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 81 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((AliceQuantum.Apply((true, q)), false, "|+⟩ is not measured as false"));
#line 82 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 84 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 85 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 86 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((AliceQuantum.Apply((true, q)), true, "|-⟩ is not measured as true"));
#line 87 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
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
            this.AliceQuantum = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(AliceQuantum));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T22_AliceQuantum_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class QubitToRegisterOperation : Operation<(ICallable,IQArray<Qubit>), QVoid>, ICallable
    {
        public QubitToRegisterOperation(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(ICallable,IQArray<Qubit>)>, IApplyData
        {
            public In((ICallable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QubitToRegisterOperation";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.QubitToRegisterOperation";
        public override Func<(ICallable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 94 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((ICallable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, ICallable op, IQArray<Qubit> qs)
        {
            return __m__.Run<QubitToRegisterOperation, (ICallable,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class QubitToRegisterOperationA : Adjointable<(IAdjointable,IQArray<Qubit>)>, ICallable
    {
        public QubitToRegisterOperationA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IAdjointable,IQArray<Qubit>)>, IApplyData
        {
            public In((IAdjointable,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "QubitToRegisterOperationA";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.QubitToRegisterOperationA";
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (op,qs) = __in__;
#line 98 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            op.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IAdjointable,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (op,qs) = __in__;
#line hidden
            op.Adjoint.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((IAdjointable,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IAdjointable op, IQArray<Qubit> qs)
        {
            return __m__.Run<QubitToRegisterOperationA, (IAdjointable,IQArray<Qubit>), QVoid>((op, qs));
        }
    }

    public partial class T23_RotateBobQubit_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T23_RotateBobQubit_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T23_RotateBobQubit_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T23_RotateBobQubit_Test";
        protected ICallable<(Int64,ICallable,IAdjointable), QVoid> MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced
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

        protected ICallable<(ICallable,IQArray<Qubit>), QVoid> QubitToRegisterOperation
        {
            get;
            set;
        }

        protected IAdjointable<(IAdjointable,IQArray<Qubit>)> QubitToRegisterOperationA
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), QVoid> RotateBobQubit
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 102 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((1L, QubitToRegisterOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg1__) => (RotateBobQubit.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg2__) => (true, __arg2__))), __arg1__))), QubitToRegisterOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg3__) => (MicrosoftQuantumIntrinsicRy.Partial(new Func<Qubit, (Double,Qubit)>((__arg4__) => (((-(2D) * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 8D), __arg4__))), __arg3__)))));
#line 104 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced.Apply((1L, QubitToRegisterOperation.Partial(new Func<IQArray<Qubit>, (ICallable,IQArray<Qubit>)>((__arg5__) => (RotateBobQubit.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg6__) => (false, __arg6__))), __arg5__))), QubitToRegisterOperationA.Partial(new Func<IQArray<Qubit>, (IAdjointable,IQArray<Qubit>)>((__arg7__) => (MicrosoftQuantumIntrinsicRy.Partial(new Func<Qubit, (Double,Qubit)>((__arg8__) => (((2D * MicrosoftQuantumMathPI.Apply(QVoid.Instance)) / 8D), __arg8__))), __arg7__)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumDiagnosticsAssertOperationsEqualReferenced = this.Factory.Get<ICallable<(Int64,ICallable,IAdjointable), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.AssertOperationsEqualReferenced));
            this.MicrosoftQuantumIntrinsicRy = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.Ry));
            this.MicrosoftQuantumMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Math.PI));
            this.QubitToRegisterOperation = this.Factory.Get<ICallable<(ICallable,IQArray<Qubit>), QVoid>>(typeof(QubitToRegisterOperation));
            this.QubitToRegisterOperationA = this.Factory.Get<IAdjointable<(IAdjointable,IQArray<Qubit>)>>(typeof(QubitToRegisterOperationA));
            this.RotateBobQubit = this.Factory.Get<ICallable<(Boolean,Qubit), QVoid>>(typeof(RotateBobQubit));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T23_RotateBobQubit_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T24_BobQuantum_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T24_BobQuantum_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T24_BobQuantum_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T24_BobQuantum_Test";
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

        protected ICallable<(Boolean,Qubit), Boolean> BobQuantum
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), QVoid> RotateBobQubit_Reference
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line hidden
            {
#line 111 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var q = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 112 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    RotateBobQubit_Reference.Apply((false, q));
#line 113 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((BobQuantum.Apply((false, q)), false, "π/8 from |0⟩ not measured as false"));
#line 114 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 116 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 117 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    RotateBobQubit_Reference.Apply((false, q));
#line 118 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((BobQuantum.Apply((false, q)), true, "π/8 from |1⟩ not measured as true"));
#line 119 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 121 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    RotateBobQubit_Reference.Apply((true, q));
#line 122 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((BobQuantum.Apply((true, q)), false, "-π/8 from |0⟩ not measured as false"));
#line 123 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicReset.Apply(q);
#line 125 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumIntrinsicX.Apply(q);
#line 126 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    RotateBobQubit_Reference.Apply((true, q));
#line 127 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    MicrosoftQuantumDiagnosticsEqualityFactB.Apply((BobQuantum.Apply((true, q)), true, "-π/8 from |1⟩ not measured as true"));
#line 128 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
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
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicReset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Reset));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.BobQuantum = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(BobQuantum));
            this.RotateBobQubit_Reference = this.Factory.Get<ICallable<(Boolean,Qubit), QVoid>>(typeof(RotateBobQubit_Reference));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T24_BobQuantum_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }

    public partial class T25_PlayQuantumCHSH_Test : Operation<QVoid, QVoid>, ICallable
    {
        public T25_PlayQuantumCHSH_Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "T25_PlayQuantumCHSH_Test";
        String ICallable.FullName => "Quantum.Kata.CHSHGame.T25_PlayQuantumCHSH_Test";
        protected ICallable<Int64, Double> MicrosoftQuantumConvertIntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Double,Double,Double), QVoid> MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> MicrosoftQuantumMathRandomInt
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Boolean> AliceQuantum
        {
            get;
            set;
        }

        protected ICallable<(Boolean,Qubit), Boolean> BobQuantum
        {
            get;
            set;
        }

        protected ICallable<(ICallable,ICallable), (Boolean,Boolean)> PlayQuantumCHSH
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 135 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            var wins = 0L;
#line 136 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            foreach (var i in new Range(1L, 10000L))
#line hidden
            {
#line 137 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var x = ((MicrosoftQuantumMathRandomInt.Apply(2L) == 1L) ? true : false);
#line 138 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var y = ((MicrosoftQuantumMathRandomInt.Apply(2L) == 1L) ? true : false);
#line 139 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                var (a,b) = PlayQuantumCHSH.Apply((AliceQuantum.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg1__) => (x, __arg1__))), BobQuantum.Partial(new Func<Qubit, (Boolean,Qubit)>((__arg2__) => (y, __arg2__)))));
#line 140 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                if (((x && y) == (a != b)))
                {
#line 141 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
                    wins = (wins + 1L);
                }
            }

#line 144 "G:\\量子实习\\quantumKatas-VS\\CHSHGame\\Tests.qs"
            MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact.Apply(((MicrosoftQuantumConvertIntAsDouble.Apply(wins) / 10000D), 0.85D, 0.01D));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertIntAsDouble = this.Factory.Get<ICallable<Int64, Double>>(typeof(Microsoft.Quantum.Convert.IntAsDouble));
            this.MicrosoftQuantumDiagnosticsEqualityWithinToleranceFact = this.Factory.Get<ICallable<(Double,Double,Double), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityWithinToleranceFact));
            this.MicrosoftQuantumMathRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.RandomInt));
            this.AliceQuantum = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(AliceQuantum));
            this.BobQuantum = this.Factory.Get<ICallable<(Boolean,Qubit), Boolean>>(typeof(BobQuantum));
            this.PlayQuantumCHSH = this.Factory.Get<ICallable<(ICallable,ICallable), (Boolean,Boolean)>>(typeof(PlayQuantumCHSH));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<T25_PlayQuantumCHSH_Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}