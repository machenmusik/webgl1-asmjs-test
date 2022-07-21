//using System.Collections.Generic;
//using System.Globalization;
using UnityEditor;
using UnityEngine;

namespace UnityBuilderAction
{
	public class BuildOptionsMenu
	{
        [MenuItem("Tools/WebGL Build Options/Target asm.js")]
        public static void WebGLBuildOptionsTargetAsmJS()
        {
            PlayerSettings.WebGL.linkerTarget = WebGLLinkerTarget.Asm; // not Wasm
        }
        
        [MenuItem("Tools/WebGL Build Options/Target wasm")]
        public static void WebGLBuildOptionsTargetWasm()
        {
            PlayerSettings.WebGL.linkerTarget = WebGLLinkerTarget.Wasm;
        }

		[MenuItem("Tools/WebGL Build Options/Memory Size 16")]
		public static void WebGLBuildOptionsSetMemory16()
		{
			PlayerSettings.WebGL.memorySize = 16;
		}

		[MenuItem("Tools/WebGL Build Options/Memory Size 32")]
		public static void WebGLBuildOptionsSetMemory32()
		{
			PlayerSettings.WebGL.memorySize = 32;
		}

		[MenuItem("Tools/WebGL Build Options/Memory Size 64")]
		public static void WebGLBuildOptionsSetMemory64()
		{
			PlayerSettings.WebGL.memorySize = 64;
		}

		[MenuItem("Tools/WebGL Build Options/Memory Size 96")]
		public static void WebGLBuildOptionsSetMemory96()
		{
			PlayerSettings.WebGL.memorySize = 96;
		}

		[MenuItem("Tools/WebGL Build Options/Memory Size 128")]
		public static void WebGLBuildOptionsSetMemory128()
		{
			PlayerSettings.WebGL.memorySize = 128;
		}

		[MenuItem("Tools/WebGL Build Options/Memory Size 256")]
		public static void WebGLBuildOptionsSetMemory256()
		{
			PlayerSettings.WebGL.memorySize = 256;
		}
	}
}
