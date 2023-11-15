using System.ComponentModel;
using Spectre.Console.Cli;

namespace HttpGenerator;

public class Settings : CommandSettings
{
    [Description("URL or file path to OpenAPI Specification file")]
    [CommandArgument(0, "[URL or input file]")]
    public string OpenApiPath { get; set; } = null!;

    [Description("Output directory")]
    [CommandOption("-o|--output <OUTPUT>")]
    [DefaultValue("./")]
    public string OutputFolder { get; set; } = "./";

    [Description("Don't log errors or collect telemetry")]
    [CommandOption("--no-logging")]
    [DefaultValue(false)]
    public bool NoLogging { get; set; }

    [Description("Skip validation of OpenAPI Specification file")]
    [CommandOption("--skip-validation")]
    [DefaultValue(false)]
    public bool SkipValidation { get; set; }
    
    [Description("Authorization header to use for all requests")]
    [CommandOption("--authorization-header <HEADER>")]
    public string? AuthorizationHeader { get; set; }
    
    [Description("Default Content-Type header to use for all requests")]
    [CommandOption("--content-type <CONTENT-TYPE>")]
    [DefaultValue("application/json")]
    public string ContentType { get; set; } = "application/json";
    
    [Description("Default Base URL to use for all requests. Use this if the OpenAPI spec doesn't explicitly specify a server URL.")]
    [CommandOption("--base-url <BASE-URL>")]
    public string? BaseUrl { get; set; }
}