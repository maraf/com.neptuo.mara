using CommonMark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Neptuo.Mara.Models
{
    public class TextModel
    {
        [XmlAttribute]
        public Language Language { get; set; }

        [XmlText]
        public string Content { get; set; }

        public string ContentToHtml()
        {
            switch (Language)
            {
                case Language.PlainText:
                case Language.Html:
                    return Content;
                case Language.Markdown:
                    CommonMarkSettings.Default.OutputDelegate = (doc, output, settings) =>
                        new HtmlFormatter(output, settings).WriteDocument(doc);

                    string content = Content;
                    if (string.IsNullOrEmpty(content))
                        return null;

                    IEnumerable<string> lines = content
                        .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    lines = lines.Select(l => l.TrimStart());
                    content = String.Join(Environment.NewLine, lines);

                    string html = CommonMarkConverter.Convert(content);
                    return html;
                default:
                    throw new NotSupportedException(Language.ToString());
            }
        }
    }

    public enum Language
    {
        PlainText,
        Markdown,
        Html
    }
}