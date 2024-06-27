// Instantiate architecture
var ctx = LLVMContextRef.Global;
var arch = new RemillArch(ctx, RemillOsId.kOSWindows, RemillArchId.kArchAMD64_AVX512);

// Load the remill semantics into a new module.
var module = RemillUtils.LoadArchSemantics(arch, Path.Combine(Directory.GetCurrentDirectory(), "Semantics"));

// Lift the trace into an LLVM IR function.
var traceInsts = new List<TraceInst>() {} // Fill in your instructions here
var function = TraceLifter.Lift(module, arch, traceInsts);