﻿using PdfTemplating.WebMVC.MovieSearch;
using PdfTemplating.XslFO.Razor.AspNet;
using System.Web.Mvc;
using System.Xml.Linq;
using PdfTemplating.XslFO;
using System.Threading.Tasks;

namespace XslFO.WebMVC.Reports.PdfRenderers.Fonet
{
    public class RazorMoviePdfRendererViaFonet : AspNetMvcRazorPdfTemplatingRenderer<MovieSearchResponse>, IPdfTemplatingRenderer<MovieSearchResponse>
    {
        public RazorMoviePdfRendererViaFonet(ControllerContext controllerContext)
            : base("~/Reports.Razor/MoviePdfReport/MoviesReport.cshtml", controllerContext)
        {}

        /// <summary>
        /// Implements the IRazorPdfRenderer interface and delegate the specific logic to the abstract
        /// methods to simplify the implementations of all inheriting Razor View Renderers.
        /// NOTE: This method orchestrates all logic to create the view model, execute the view template,
        ///         and render the XSL-FO output, and then convert that XSL-FO output to a valid Pdf
        ///         in one and only place and greatly simplifies all Razor View Renderers to keep
        ///         code very DRY.
        /// </summary>
        /// <param name="templateModel"></param>
        /// <returns></returns>
        public virtual byte[] RenderPdf(MovieSearchResponse templateModel)
        {
            //***********************************************************
            //Execute the Razor View to generate the XSL-FO output
            //***********************************************************
            var razorViewRenderer = new AspNetMvcRazorViewRenderer(this.ControllerContext);
            var renderResult = razorViewRenderer.RenderView(this.RazorViewVirtualPath, templateModel);

            //Load the XSL-FO output into a fully validated XDocument.
            //NOTE: This template must generate valid Xsl-FO output -- via the well-formed xml we load into the XDocument return value -- to be rendered as a Pdf Binary!
            var xslFODoc = XDocument.Parse(renderResult.RenderOutput);

            //Create the Pdf Options for the XSL-FO Rendering engine to use
            var pdfOptions = this.CreatePdfOptions();

            //****************************************************************************
            //Execute the Trasnformation of the XSL-FO source to Binary Pdf via Fonet
            //****************************************************************************
            var xslFOPdfRenderer = new FONetXslFOPdfRenderer(xslFODoc, pdfOptions);
            var pdfBytes = xslFOPdfRenderer.RenderPdfBytes();
            return pdfBytes;
        }
    }
}