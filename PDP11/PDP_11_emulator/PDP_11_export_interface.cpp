#include <stdlib.h>

__declspec(dllexport) bool PDP_11_is_register_change() {
	return 1;
}

__declspec(dllexport) bool PDP_11_is_VRAM_change() {
	return 1;
}

__declspec(dllexport) void* PDP_11_get_new_registers() {
	return NULL;
}

__declspec(dllexport) void* PDP_11_get_new_VRAM() {
	return NULL;
}