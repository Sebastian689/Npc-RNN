#pragma once

#ifdef EXPORTS
#define RNN_API __declspec(dllexport)
#else
#define RNN_API __declspec(dllimport)
#endif

extern "C" RNN_API int test_number();