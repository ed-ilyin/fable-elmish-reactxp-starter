module.exports = {
    entry: "./src/index.jsx",
    output: {
        filename: "bundle.js",
        path: __dirname + "/dist"
    },

    // Enable sourcemaps for debugging webpack's output.
    devtool: "source-map",

    resolve: {
        // Add '.ts' and '.tsx' as resolvable extensions.
        extensions: [".webpack.js", ".web.js", ".js", ".jsx"]
    },

    module: {

        loaders: [
            // {
            //     test: /\.fs(x|proj)?$/,
            //     use: {
            //         loader: "fable-loader",
            //         options: {
            //             babel: babelOptions,
            //             define: isProduction ? [] : ["DEBUG"]
            //         }
            //     }
            // },
            // All files with a '.js' or '.jsx' extension will be handled by 'babel-loader'.
            { test: /\.jsx?$/, loader: 'babel-loader' },
        ]
    },
};