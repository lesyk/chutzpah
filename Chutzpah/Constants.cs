namespace Chutzpah
{
    public static class Constants
    {
        public const string ChutzpahVersion = "3.0.1";

        public const string TestFileFolder = "TestFiles";

        public const string LogFileName = "chutzpah.log";

        // Name of the test settings file
        public const string SettingsFileName = "chutzpah.json";

        // Default time in milliseconds to wait for new test results. If we don't hear anything
        // from phantom after this amount of time abort
        public const int DefaultTestFileTimeout = 10000;

        // Default of how many files to open during test file discovery
        public const int DefaultFileSeachLimit = 10000;

        // The max-size in bytes for the compilercache file
        public const int DefaultCompilerCacheFileMaxSize = 32*1024*1024;

        // Format for temporary files Chutzpah creates that should be ignored in source controler.
        // These get generated when Chutzpah needs to generate a file in place like when it needs to convert 
        // Coffee script to JS
        public const string ChutzpahTemporaryFilePrefix = "_Chutzpah.";
        public const string ChutzpahTemporaryFileFormat = ChutzpahTemporaryFilePrefix + "{0}.{1}";

        public const string ChutzpahCompilerCacheFolder = ChutzpahTemporaryFilePrefix + "cache";
        public const string ChutzpahCompilerCacheFileName = ChutzpahTemporaryFilePrefix + "cache";

        public const string CoverageJsonFileName = ChutzpahTemporaryFilePrefix + "coverage.json";
        public const string CoverageHtmlFileName = ChutzpahTemporaryFilePrefix + "coverage.html";

        // Used to communicate between the coverage engine and the JS runner, for Chutzpah
        // to be able to get hold of the coverage object.
        public const string ChutzpahCoverageObjectReference = "_Chutzpah_covobj_name";

        public const string PngExtension = ".png";
        public const string CssExtension = ".css";
        public const string JavaScriptExtension = ".js";
        public const string TypeScriptExtension = ".ts";
        public const string TypeScriptDefExtension = ".d.ts";
        public const string CoffeeScriptExtension = ".coffee";
        public const string HtmScriptExtension = ".htm";
        public const string HtmlScriptExtension = ".html";

        public const string MochaBddInterface = "bdd";
        public const string MochaQunitInterface = "qunit";
        public const string MochaTddInterface = "tdd";
        public const string MochaExportsInterface = "exports";

    }
}
