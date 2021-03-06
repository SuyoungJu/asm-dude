﻿namespace AsmTools {

    /// <summary>Register Name Enumeration</summary>
    public enum Rn {
        NOREG,
        RAX, EAX, AX, AL, AH,
        RBX, EBX, BX, BL, BH,
        RCX, ECX, CX, CL, CH,
        RDX, EDX, DX, DL, DH,

        RSI, ESI, SI, SIL,
        RDI, EDI, DI, DIL,
        RBP, EBP, BP, BPL,
        RSP, ESP, SP, SPL,

        R8, R8D, R8W, R8B,
        R9, R9D, R9W, R9B,
        R10, R10D, R10W, R10B,
        R11, R11D, R11W, R11B,

        R12, R12D, R12W, R12B,
        R13, R13D, R13W, R13B,
        R14, R14D, R14W, R14B,
        R15, R15D, R15W, R15B,

        MM0, MM1, MM2, MM3, MM4, MM5, MM6, MM7,

        XMM0, XMM1, XMM2, XMM3, XMM4, XMM5, XMM6, XMM7,
        XMM8, XMM9, XMM10, XMM11, XMM12, XMM13, XMM14, XMM15,
        XMM16, XMM17, XMM18, XMM19, XMM20, XMM21, XMM22, XMM23,
        XMM24, XMM25, XMM26, XMM27, XMM28, XMM29, XMM30, XMM31,

        YMM0, YMM1, YMM2, YMM3, YMM4, YMM5, YMM6, YMM7,
        YMM8, YMM9, YMM10, YMM11, YMM12, YMM13, YMM14, YMM15,
        YMM16, YMM17, YMM18, YMM19, YMM20, YMM21, YMM22, YMM23,
        YMM24, YMM25, YMM26, YMM27, YMM28, YMM29, YMM30, YMM31,

        ZMM0, ZMM1, ZMM2, ZMM3, ZMM4, ZMM5, ZMM6, ZMM7,
        ZMM8, ZMM9, ZMM10, ZMM11, ZMM12, ZMM13, ZMM14, ZMM15,
        ZMM16, ZMM17, ZMM18, ZMM19, ZMM20, ZMM21, ZMM22, ZMM23,
        ZMM24, ZMM25, ZMM26, ZMM27, ZMM28, ZMM29, ZMM30, ZMM31,

        K0, K1, K2, K3, K4, K5, K6, K7,

        CS, DS, ES, SS, FS, GS,

        CR0, CR1, CR2, CR3, CR4, CR5, CR6, CR7, CR8,
        DR0, DR1, DR2, DR3, DR4, DR5, DR6, DR7,
        BND0, BND1, BND2, BND3
    };
}
