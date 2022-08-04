using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;

namespace Umbraco10.Migrator.DocumentTypes.Components.Builders

{
    public class MacroComponentBuilder : ComponentBuilder
    {
        private const string PropertyAlias = "macro";

        public MacroComponentBuilder(IContentTypeService contentTypeService, IShortStringHelper shortStringHelper, IDataTypeService dataTypeService) : base(
            contentTypeService, shortStringHelper, dataTypeService)
        {
        }

        public override bool CanBuild(string propertyAlias)
        {
            return PropertyAlias.Equals(propertyAlias);
        }

        public override void Build()
        {
            AddProperty("value", Constants.DataTypes.Textarea);
            Save();
        }
    }
}