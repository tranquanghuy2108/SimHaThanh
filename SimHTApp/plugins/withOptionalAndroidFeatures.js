const { withAndroidManifest } = require("expo/config-plugins");

// Override both implied requirements and requirements merged from libraries.
module.exports = function withOptionalAndroidFeatures(config) {
  return withAndroidManifest(config, (config) => {
    const manifest = config.modResults.manifest;
    manifest.$["xmlns:tools"] = "http://schemas.android.com/tools";
    const features = (manifest["uses-feature"] ??= []);

    for (const name of [
      "android.hardware.screen.portrait",
      "android.hardware.wifi",
    ]) {
      let feature = features.find((entry) => entry.$["android:name"] === name);
      if (!feature) {
        feature = { $: { "android:name": name } };
        features.push(feature);
      }
      feature.$["android:required"] = "false";
      const replacements = new Set(
        (feature.$["tools:replace"] || "").split(",").map((key) => key.trim()).filter(Boolean),
      );
      replacements.add("android:required");
      feature.$["tools:replace"] = [...replacements].join(",");
    }
    return config;
  });
};
