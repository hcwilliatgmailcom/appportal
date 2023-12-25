using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace appportal;

public partial class Email
{
    public EntityInfo GetEntityInfo() { return new EntityInfo{Id=1}; }
     
    public Dictionary<string,AttributeInfo> GetAttributeInfo (){

        Dictionary<string,AttributeInfo> propertynumbers =new Dictionary<string,AttributeInfo>();
        propertynumbers.Add(nameof(Email.Id),new AttributeInfo{Id=1});
        return propertynumbers;

    }
 
}

public class EntityInfo
{
    public int Id { get; set; }
}

public class AttributeInfo
{
    public int Id { get; set; }
}