using UnityEditor;
using UnityEngine.Rendering;

// MaterialProperty.propertyType/propertyFlags only exist in newer Unity 6 versions;
// older versions expose type/flags (PropType/PropFlags share the same enum values)

internal static class TCP2_MaterialPropertyCompat
{
	public static ShaderPropertyType GetPropertyType(this MaterialProperty prop)
	{
#if UNITY_6000_3_OR_NEWER
		return prop.propertyType;
#else
		return (ShaderPropertyType)prop.type;
#endif
	}

	public static ShaderPropertyFlags GetPropertyFlags(this MaterialProperty prop)
	{
#if UNITY_6000_3_OR_NEWER
		return prop.propertyFlags;
#else
		return (ShaderPropertyFlags)prop.flags;
#endif
	}
}
