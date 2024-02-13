using System.ComponentModel.Composition;
using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;

namespace RhetosExtensions.MyFirstConcept
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("PhoneNumber")]
    public class PhoneNumberInfo : ShortStringPropertyInfo
    {
    }
}
