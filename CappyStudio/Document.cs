using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xceed.Document.NET;
using Xceed.Words.NET;

namespace CappyStudio
{
    static class Document
    {
        public static void BuildDoc(string[] interactions)
        {
            string outPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $@"\Cappy-{Studio.GetSaveTime()}.doc";
            using(DocX doc = DocX.Create(outPath))
            {
                foreach (var interaction in interactions)
                {
                    string[] values = interaction.Split(';');

                    string ButtonAction = String.Empty;
                    string ButtonClicked = String.Empty;
                    string WindowText = String.Empty;
                    string ParagraphText = ButtonAction + ButtonClicked;
                    string FullFileName = String.Empty;
                    string FocusFileName = String.Empty;

                    if (values.Length == 5)
                    {
                        ButtonAction = values[0];
                        ButtonClicked = values[1];
                        WindowText = values[2];
                        FullFileName = values[3];
                        FocusFileName = values[4];

                        if (!String.IsNullOrEmpty(WindowText))
                        {
                            ParagraphText = ButtonAction + " " + WindowText;
                        }
                        else
                        {
                            // if we can't determine what was clicked, resort to this.
                            ParagraphText = ButtonAction + " << FILL IN MISSING TEXT >>";
                        }
                    }
                    else if (values.Length == 3)
                    {
                        ButtonAction = values[0];
                        ButtonClicked = values[1];
                        FullFileName = values[2];
                    }

                    if (values.Length == 5)
                    {
                        // create our paragraph to work with
                        Paragraph p = doc.InsertParagraph();

                        // get bitmaps of the desired images
                        System.Drawing.Image FullCaptureImage = ImageMethods.GetImage(FullFileName);
                        System.Drawing.Image FocusCaptureImage = ImageMethods.GetImage(FocusFileName);

                        // instantiate memory streams for writing our bitmaps to
                        MemoryStream FullCaptureStream = new MemoryStream();
                        MemoryStream FocusCaptureStream = new MemoryStream();

                        // save our bitmaps into the memory stream
                        FullCaptureImage.Save(FullCaptureStream, FullCaptureImage.RawFormat);
                        FocusCaptureImage.Save(FocusCaptureStream, FocusCaptureImage.RawFormat);

                        // set position in memory stream
                        FullCaptureStream.Seek(0, SeekOrigin.Begin);
                        FocusCaptureStream.Seek(0, SeekOrigin.Begin);

                        // create the base image to work with, and add it to our document object for later
                        Xceed.Document.NET.Image FullCapture = doc.AddImage(FullCaptureStream);
                        Xceed.Document.NET.Image FocusCapture = doc.AddImage(FocusCaptureStream);

                        // convert image to picture usable in a document
                        Picture FullCapturePic = FullCapture.CreatePicture();
                        Picture FocusCapturePic = FocusCapture.CreatePicture();

                        // because screenshots will be a constant size, simply set a scalar to our desired resolution. we can also use this for calculating the focus size.
                        const int imgWidth = 512;
                        const int imgHeight = 288;

                        // apply aforementioned scalar
                        FullCapturePic.Width = imgWidth;
                        FullCapturePic.Height = imgHeight;

                        // create focused screenshot size
                        Size focusbbox = new Size(imgWidth, imgHeight);

                        // get the scaled version of focused image
                        Size focusSize = ImageMethods.ExpandToBound(FocusCaptureImage.Size, focusbbox);
                        FocusCapturePic.Width = focusSize.Width;
                        FocusCapturePic.Height = focusSize.Height;

                        // insert bullet list
                        var list = doc.AddList(listType: ListItemType.Numbered, continueNumbering: true);
                        doc.AddListItem(list, ParagraphText, 0, listType: ListItemType.Numbered);

                        // insert images
                        p.InsertListBeforeSelf(list);
                        p.AppendLine().AppendPicture(FullCapturePic);
                        p.AppendLine(); // space the images
                        p.AppendLine().AppendPicture(FocusCapturePic);
                        p.AppendLine(); // leave a space for writing

                        p.InsertPageBreakAfterSelf();

                        // release unneeded resources
                        FullCaptureImage.Dispose();
                        FullCaptureStream.Dispose();
                        FocusCaptureImage.Dispose();
                        FocusCaptureStream.Dispose();
                    }
                    else if(values.Length == 3)
                    {
                        // create our paragraph to work with
                        Paragraph p = doc.InsertParagraph();

                        // get bitmaps of the desired images
                        System.Drawing.Image FullCaptureImage = ImageMethods.GetImage(FullFileName);

                        // instantiate memory streams for writing our bitmaps to
                        MemoryStream FullCaptureStream = new MemoryStream();

                        // save our bitmaps into the memory stream
                        FullCaptureImage.Save(FullCaptureStream, FullCaptureImage.RawFormat);

                        // set position in memory stream
                        FullCaptureStream.Seek(0, SeekOrigin.Begin);

                        // create the base image to work with, and add it to our document object for later
                        Xceed.Document.NET.Image FullCapture = doc.AddImage(FullCaptureStream);

                        // convert image to picture usable in a document
                        Picture FullCapturePic = FullCapture.CreatePicture();

                        // because screenshots will be a constant size, simply set a scalar to our desired resolution. we can also use this for calculating the focus size.
                        const int imgWidth = 512;
                        const int imgHeight = 288;

                        // apply aforementioned scalar
                        FullCapturePic.Width = imgWidth;
                        FullCapturePic.Height = imgHeight;

                        // insert bullet list
                        var list = doc.AddList(listType: ListItemType.Numbered, continueNumbering: true);
                        doc.AddListItem(list, ParagraphText, 0, listType: ListItemType.Numbered);

                        // insert images
                        p.InsertListBeforeSelf(list);
                        p.AppendLine().AppendPicture(FullCapturePic);
                        p.AppendLine(); // space the images

                        // leave a space for writing
                        p.InsertPageBreakAfterSelf();

                        // release unneeded resources
                        FullCaptureImage.Dispose();
                        FullCaptureStream.Dispose();
                    }
                }
                doc.Save();
            }
        }
    }
}
