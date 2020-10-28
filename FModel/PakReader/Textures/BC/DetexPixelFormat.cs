﻿namespace FModel.PakReader.Textures.BC
{
    public enum DetexPixelFormat : uint
    {
        /* The format has 16-bit components. */
        DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT = 0x1,

        /* The format has 32-bit components. */
        DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT = 0x2,

        /* The format has an alpha component. */
        DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT = 0x4,

        /* The sequential component order is RGB. */
        DETEX_PIXEL_FORMAT_RGB_COMPONENT_ORDER_BIT = 0x0,

        /* The sequential component order is BGR. */
        DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT = 0x8,

        /* The format has one component. */
        DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS = 0x0,

        /* The format has two components. */
        DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS = 0x10,

        /* The format has three components. */
        DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS = 0x20,

        /* The format has four components. */
        DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS = 0x30,

        /* The format is stored as 8-bit pixels. */
        DETEX_PIXEL_FORMAT_8BIT_PIXEL_BITS = 0x000,

        /* The format is stored as 16-bit pixels. */
        DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS = 0x100,

        /* The format is stored as 24-bit pixels. */
        DETEX_PIXEL_FORMAT_24BIT_PIXEL_BITS = 0x200,

        /* The format is stored as 32-bit pixels. */
        DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS = 0x300,

        /* The format is stored as 48-bit pixels. */
        DETEX_PIXEL_FORMAT_48BIT_PIXEL_BITS = 0x500,

        /* The format is stored as 64-bit pixels. */
        DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS = 0x700,

        /* The format is stored as 96-bit pixels. */
        DETEX_PIXEL_FORMAT_96BIT_PIXEL_BITS = 0xB00,

        /* The format is stored as 128-bit pixels. */
        DETEX_PIXEL_FORMAT_128BIT_PIXEL_BITS = 0xF00,

        /* The format has signed integer components. */
        DETEX_PIXEL_FORMAT_SIGNED_BIT = 0x1000,

        /* The format has (half-)float components. */
        DETEX_PIXEL_FORMAT_FLOAT_BIT = 0x2000,

        /* The fomat is HDR (high dynamic range). */
        DETEX_PIXEL_FORMAT_HDR_BIT = 0x4000,

        DETEX_PIXEL_FORMAT_RGBA8 = (
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_BGRA8 = (
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_RGBX8 = (
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_BGRX8 = (
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_RGB8 = (
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_24BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_BGR8 = (
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_24BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_R8 = (
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_8BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_SIGNED_R8 = (
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_8BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT
        ),

        DETEX_PIXEL_FORMAT_RG8 = (
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_SIGNED_RG8 = (
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT
        ),

        DETEX_PIXEL_FORMAT_R16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_SIGNED_R16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT
        ),

        DETEX_PIXEL_FORMAT_RG16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_SIGNED_RG16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT
        ),

        DETEX_PIXEL_FORMAT_RGB16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_48BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_RGBX16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_RGBA16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS
        ),

        DETEX_PIXEL_FORMAT_FLOAT_R16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_R16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_16BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RG16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RG16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBX16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBX16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBA16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBA16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGB16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_48BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGB16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_48BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_BGRX16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_BGRX16_HDR = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_SIGNED_FLOAT_RGBX16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_SIGNED_FLOAT_BGRX16 = (
            DETEX_PIXEL_FORMAT_16BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_BGR_COMPONENT_ORDER_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_SIGNED_BIT |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_R32 = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_R32_HDR = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_32BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RG32 = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RG32_HDR = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_TWO_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_64BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGB32 = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_96BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGB32_HDR = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_96BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBX32 = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_128BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBX32_HDR = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_THREE_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_128BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBA32 = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_128BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT
        ),

        DETEX_PIXEL_FORMAT_FLOAT_RGBA32_HDR = (
            DETEX_PIXEL_FORMAT_32BIT_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_FOUR_COMPONENTS_BITS |
            DETEX_PIXEL_FORMAT_128BIT_PIXEL_BITS |
            DETEX_PIXEL_FORMAT_FLOAT_BIT |
            DETEX_PIXEL_FORMAT_HDR_BIT
        ),

        DETEX_PIXEL_FORMAT_A8 = (
            DETEX_PIXEL_FORMAT_ALPHA_COMPONENT_BIT |
            DETEX_PIXEL_FORMAT_ONE_COMPONENT_BITS |
            DETEX_PIXEL_FORMAT_8BIT_PIXEL_BITS
        ),
    }
}