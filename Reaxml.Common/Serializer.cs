using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Reaxml.Common
{
    public class Serializer
    {
        private readonly string targetSchemaFilePath;
        private readonly List<string> warnings;
        private readonly List<string> errors;
 
        public Serializer(string targetSchemaFilePath = "reaxml.xsd")
        {
            this.targetSchemaFilePath = targetSchemaFilePath;
            warnings = new List<string>();
            errors = new List<string>();
        }

        public ReaxmlSerializationResult Serialize(Stream stream)
        {
            // Set the validation settings.
            var settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessInlineSchema;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            settings.DtdProcessing = DtdProcessing.Ignore;
            settings.Schemas.Add("", targetSchemaFilePath);
            
            var reader = XmlReader.Create(stream, settings);
            var serializer = new XmlSerializer(typeof (propertyList));
            var propertyList = serializer.Deserialize(reader) as propertyList;

            return new ReaxmlSerializationResult()
            {
                Errors = errors,
                Warnings = warnings,
                PropertyList = propertyList
            };
        }

        // Display any warnings or errors.
        private void ValidationCallBack(object sender, ValidationEventArgs args)
        {
            if (args.Severity == XmlSeverityType.Warning)
                warnings.Add(string.Format("Warning: {0}", args.Message));
            else
                errors.Add(string.Format(
                    "Error at Line {0}({1}): {2}", 
                    args.Exception.LineNumber, 
                    args.Exception.LinePosition, 
                    args.Message));
        }
    }
}
