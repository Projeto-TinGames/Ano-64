using UnityEngine;
using UnityEngine.Rendering;

public class RendererManager : MonoBehaviour {
    private enum RenderDimension { TwoDimensions, ThreeDimensions };
    [SerializeField]private RenderDimension dimension;

    [SerializeField]private RenderPipelineAsset TwoDimensionsAsset;
    [SerializeField]private RenderPipelineAsset ThreeDimensionsAsset;

    void Awake() {
        if (dimension == 0) {
            GraphicsSettings.renderPipelineAsset = TwoDimensionsAsset;
        }

        else {
            GraphicsSettings.renderPipelineAsset = ThreeDimensionsAsset;
        }
    }

}
