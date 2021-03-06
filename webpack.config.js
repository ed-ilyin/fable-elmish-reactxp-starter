const path = require("path");

function resolve(filePath) {
    return path.join(__dirname, filePath)
}

module.exports = {
    entry: resolve("./src/App/App.fsproj"),
    output: {
        filename: "bundle.js",
        path: resolve("./dist")
    },
    // Enable sourcemaps for debugging webpack's output.
    devtool: "source-map",
    resolve: {
        // Add '.ts' and '.tsx' as resolvable extensions.
        extensions: [".webpack.js", ".web.js", ".js", ".jsx"],
        modules: [
            "node_modules", resolve("./node_modules/")
        ]
    },
    module: {
        loaders: [
            { test: /\.fs(x|proj)?$/, loader: "fable-loader" },
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: { loader: 'babel-loader' },
            }
        ]
    },
}